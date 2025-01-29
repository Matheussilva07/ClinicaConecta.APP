using AutoMapper;
using clinica.Communication.Pacientes.Requests;
using clinica.Domain.Entities;
using clinica.Domain.Repositories.Pacientes;

namespace clinica.Application.PacientesUseCases.Update;
internal class UpdatePacienteUseCase : IUpdatePacienteUseCase
{
	private readonly IMapper _mapper;
	private readonly IUpdateOnly_Pacientes_Repository _repository;

	public UpdatePacienteUseCase(IMapper mapper, IUpdateOnly_Pacientes_Repository repository)
	{
		_mapper = mapper;
		_repository = repository;
	}

	public async Task ExecuteAsync(RequestUpdatePacienteJson request, string id)
	{
		Validate(request);

		var dadosNovos = _mapper.Map<Paciente>(request);

		bool result = await _repository.UpdateAsync(dadosNovos, id);

		if (result == false)
		{
			throw new Exception("Erro na atualização do paciente");
		}
	}
	private static void Validate(RequestUpdatePacienteJson request)
	{
		var result = new UpdatePacientesValidator().Validate(request);

		if (result.IsValid == false)
		{
			throw new ArgumentException("Dados inválidos");
		}
	}
}
