using clinica.Domain.Entities;

namespace clinica.Application.PacientesUseCases.GetAll;
public interface IGetAllPacientesUseCase
{
	Task<List<Paciente>> ExecuteAsync();
}

