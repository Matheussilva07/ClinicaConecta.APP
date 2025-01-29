using AutoMapper;
using clinica.Communication.Pacientes.Responses;
using clinica.Domain.Repositories.Pacientes;

namespace clinica.Application.PacientesUseCases.GetByName;
internal class GetPacienteByNameUseCase : IGetPacienteByNameUseCase
{
	private readonly IMapper _mapper;
	private readonly IReadOnly_Pacientes_Repository _repository;

	public GetPacienteByNameUseCase(IMapper mapper, IReadOnly_Pacientes_Repository repository)
	{
		_mapper = mapper;
		_repository = repository;
	}
	public async Task<ResponsePacienteGettedByNameJson?> ExecuteAsync(string name)
	{
		var paciente = await _repository.GetByName(name) ?? throw new ArgumentException("Paciente não encontrado!");
	
		return _mapper.Map<ResponsePacienteGettedByNameJson>(paciente);
	}
}
