using clinica.Domain.Entities;

namespace clinica.Domain.Repositories.Pacientes;
public interface IWriteOnlyPacientesRepository
{
    Task AddAsync(Paciente paciente);
    Task DeleteAsync(string id);
}
