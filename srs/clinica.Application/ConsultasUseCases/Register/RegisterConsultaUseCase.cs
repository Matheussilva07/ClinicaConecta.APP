using AutoMapper;
using clinica.Communication.Consultas.Requests;
using clinica.Communication.Consultas.Responses;
using clinica.Domain.Entities;
using clinica.Domain.Repositories.Consultas;

namespace clinica.Application.ConsultasUseCases.Register;
public class RegisterConsultaUseCase : IRegisterConsultaUseCase
{
	private readonly IWriteOnlyConsultasRepository _repository;
	private readonly IMapper _mapper;
	public RegisterConsultaUseCase(IWriteOnlyConsultasRepository repository, IMapper mapper)
	{
		_repository = repository;
		_mapper = mapper;
	}

	public async Task<ResponseRegisteredConsultaJson> ExecuteAsync(RequestRegisterConsultaJson request)
	{
		Validate(request);

		var consulta = _mapper.Map<Consulta>(request);

		await _repository.AddAsync(consulta);

		return _mapper.Map<ResponseRegisteredConsultaJson>(consulta);
	}

	private static void Validate(RequestRegisterConsultaJson request)
	{
		var result = new ConsultasValidator().Validate(request);

		if (result.IsValid == false)
		{
			throw new ArgumentException("Dados inválidos!");
		}
	}
}
