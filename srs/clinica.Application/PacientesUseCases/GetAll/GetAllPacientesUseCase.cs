using AutoMapper;
using clinica.Domain.Entities;
using clinica.Domain.Repositories.Pacientes;

namespace clinica.Application.PacientesUseCases.GetAll;
internal class GetAllPacientesUseCase : IGetAllPacientesUseCase
{
	private readonly IMapper _mapper;
	private readonly IReadOnlyPacientesRepository _repository;

	public GetAllPacientesUseCase(IMapper mapper, IReadOnlyPacientesRepository repository)
	{
		_mapper = mapper;
		_repository = repository;
	}

	public async Task<List<Paciente>> ExecuteAsync()
	{
		var pacientes = await _repository.GetAllAsync();

		return _mapper.Map<List<Paciente>>(pacientes);	
	}
}
