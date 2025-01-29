using AutoMapper;
using clinica.Domain.Entities;
using clinica.Domain.Repositories.Pacientes;

namespace clinica.Application.PacientesUseCases.Delete;
internal class DeletePacienteUseCase : IDeletePacienteUseCase
{
	private readonly IWriteOnly_Pacientes_Repository _repository;
	public DeletePacienteUseCase(IWriteOnly_Pacientes_Repository repository)
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
