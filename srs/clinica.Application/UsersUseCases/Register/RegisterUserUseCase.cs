using AutoMapper;
using clinica.Communication.Users.Requests;
using clinica.Communication.Users.Responses;
using clinica.Domain.Entities;
using clinica.Domain.Repositories.Users;
using clinica.Domain.Security.Cryptography;
using clinica.Domain.Security.Token;

namespace clinica.Application.UsersUseCases.Register;
internal class RegisterUserUseCase : IRegisterUserUseCase
{
	private readonly IMapper _mapper;
	private readonly ITokenGenerator _tokenGenerator;
	private readonly IWriteOnlyUserRepository _repository;
	private readonly IReadOnlyUserRepository _readOnlyRepository;
	private readonly IPasswordEncryptor _encryptor;

	public RegisterUserUseCase(IMapper mapper, IWriteOnlyUserRepository repository, ITokenGenerator tokenGenerator, IPasswordEncryptor encryptor, IReadOnlyUserRepository readOnlyRepository)
	{
		_mapper = mapper;
		_repository = repository;
		_tokenGenerator = tokenGenerator;
		_encryptor = encryptor;
		_readOnlyRepository = readOnlyRepository;
	}

	public async Task<ResponseUserJson> ExecuteAsync(RequestRegisterUserJson request)
	{
		await Validate(request);	

		var user = _mapper.Map<User>(request);
		user.Password = _encryptor.Encrypte(request.Password); 
		user.UserIdentifier = Guid.NewGuid();

		await _repository.AddAsync(user);

		return new ResponseUserJson
		{
			Name = user.Name,
			Token = _tokenGenerator.GenerateToken(user)
		};
	}
	private async Task Validate(RequestRegisterUserJson request)
	{
		var result = new UsersValidator().Validate(request);

		bool userExists = await _readOnlyRepository.ExistUserWithThisEmail(request.Email);

		if (userExists)
		{
			throw new ArgumentException("Usuário já existe");
		}

		if (!result.IsValid)
		{
			foreach(var erros  in result.Errors)
			{
				throw new ArgumentException(erros.ErrorMessage);
			}		
		}
	}
}
