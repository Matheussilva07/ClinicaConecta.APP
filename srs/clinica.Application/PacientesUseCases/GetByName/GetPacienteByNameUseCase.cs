using AutoMapper;
using clinica.Communication.Pacientes.Responses;
using clinica.Domain.Repositories.Pacientes;

namespace clinica.Application.PacientesUseCases.GetByName;
internal class GetPacienteByNameUseCase : IGetPacienteByNameUseCase
{
	private readonly IMapper _mapper;
	private readonly IReadOnlyPacientesRepository _repository;

	public GetPacienteByNameUseCase(IMapper mapper, IReadOnlyPacientesRepository repository)
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
