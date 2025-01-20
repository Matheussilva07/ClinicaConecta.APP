using clinica.Domain.Entities;

namespace clinica.Domain.Repositories;
public interface IUpdateOnly_Pacientes_Repository
{
	Task<bool> UpdateAsync(Paciente paciente, string name);
}
