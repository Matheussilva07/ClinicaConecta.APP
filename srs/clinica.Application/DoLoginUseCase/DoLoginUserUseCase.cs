using AutoMapper;
using clinica.Communication.Users.Requests;
using clinica.Communication.Users.Responses;
using clinica.Domain.Repositories.Users;
using clinica.Domain.Security.Cryptography;
using clinica.Domain.Security.Token;
using System.ComponentModel.DataAnnotations;

namespace clinica.Application.DoLoginUseCase;
internal class DoLoginUserUseCase : IDoLoginUserUseCase
{
	private readonly IMapper _mapper;
	private readonly IReadOnlyUserRepository _repository;
	private readonly IPasswordEncryptor _passwordEncryptor;
	private readonly ITokenGenerator _tokenGenerator;
	public DoLoginUserUseCase(IReadOnlyUserRepository repository, IPasswordEncryptor passwordEncryptor, IMapper mapper, ITokenGenerator tokenGenerator)
	{
		_repository = repository;
		_passwordEncryptor = passwordEncryptor;
		_mapper = mapper;
		_tokenGenerator = tokenGenerator;
	}

	public async Task<ResponseUserJson> ExecuteAsync(RequestDoLoginJson request)
	{
		ValidateEmail(email: request.Email);

		var user = await _repository.GetUserByEmail(request.Email) ?? throw new ArgumentException("Usuário inexistente");

		bool passwordMatch = _passwordEncryptor.VerifyPassword(request.Password, user.Password);

		if(!passwordMatch)
		{
			throw new ArgumentException("Senha inválida");
		}

		return new ResponseUserJson
		{
			Name = user.Name,
			Token = _tokenGenerator.GenerateToken(user)
		};
	}
	private static void ValidateEmail(string email)
	{
		if (string.IsNullOrWhiteSpace(email))
		{
			throw new ArgumentException("Digite o email!");
		}
		var emailValidator = new EmailAddressAttribute();

		if(emailValidator.IsValid(email) == false)
		{
			throw new ArgumentException("Email inválido!");
		}
	}
}
