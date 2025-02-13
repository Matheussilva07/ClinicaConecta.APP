using clinica.Domain.Entities;

namespace clinica.Domain.Repositories.Pacientes;
public interface IReadOnlyPacientesRepository
{
    Task<List<Paciente>> GetAllAsync();
    Task<Paciente?> GetByName(string name);
}
