using AutoMapper;
using clinica.Communication.Pacientes.Requests;
using clinica.Communication.Pacientes.Responses;
using clinica.Domain.Entities;
using clinica.Domain.Repositories.Pacientes;

namespace clinica.Application.PacientesUseCases.Register;
internal class RegisterPacienteUseCase : IRegisterPacienteUseCase
{	
	private readonly IMapper _mapper;
	private readonly IWriteOnly_Pacientes_Repository _repository;

	public RegisterPacienteUseCase(IWriteOnly_Pacientes_Repository repository, IMapper mapper)
	{
		_repository = repository;
		_mapper = mapper;
	}

	public async Task<ResponseRegisteredPacienteJson> ExecuteAsync(RequestRegisterPacienteJson request)
	{
		Validate(request);

		var paciente = _mapper.Map<Paciente>(request);
			
		await _repository.AddAsync(paciente);

		return _mapper.Map<ResponseRegisteredPacienteJson>(paciente);
	}
	private static void Validate(RequestRegisterPacienteJson request)
	{
		var validator = new PacientesValidator();

		var result = validator.Validate(request);

		if (result.IsValid == false)
		{
			throw new ArgumentException("Dados Inválidos!");
		}
	}
}
