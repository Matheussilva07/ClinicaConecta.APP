using clinica.Domain.Entities;

namespace clinica.Domain.Repositories.Pacientes;
public interface IReadOnly_Pacientes_Repository
{
    Task<List<Paciente>> GetAllAsync();
    Task<Paciente?> GetByName(string name);
}
