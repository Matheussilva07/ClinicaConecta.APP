using clinica.Domain.Entities;

namespace clinica.Application.PacientesUseCases.Delete;
public interface IDeletePacienteUseCase
{
	Task ExecuteAsync(string id);
}
