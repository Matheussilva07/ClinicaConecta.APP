using clinica.Domain.Entities;

namespace clinica.Domain.Repositories.Pacientes;
public interface IWriteOnly_Pacientes_Repository
{
    Task AddAsync(Paciente paciente);
    Task DeleteAsync(string id);
}
