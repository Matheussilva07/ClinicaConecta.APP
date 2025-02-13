using AutoMapper;
using clinica.Domain.Entities;
using clinica.Domain.Repositories.Pacientes;

namespace clinica.Application.PacientesUseCases.Delete;
internal class DeletePacienteUseCase : IDeletePacienteUseCase
{
	private readonly IWriteOnlyPacientesRepository _repository;
	public DeletePacienteUseCase(IWriteOnlyPacientesRepository repository)
	{
		_repository = repository;
	}

	public async Task ExecuteAsync(string id)
	{	
		if (id is not null)
		{
			await _repository.DeleteAsync(id);
		}

		return;
	}
}
