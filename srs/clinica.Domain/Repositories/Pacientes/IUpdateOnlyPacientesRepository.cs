using clinica.Domain.Entities;

namespace clinica.Domain.Repositories.Pacientes;
public interface IUpdateOnlyPacientesRepository
{
    Task<bool> UpdateAsync(Paciente paciente, string id);
}
