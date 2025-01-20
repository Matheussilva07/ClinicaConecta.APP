using clinica.Domain.Entities;

namespace clinica.Domain.Repositories;
public interface IWriteOnly_Pacientes_Repository
{
	Task AddAsync(Paciente paciente);
}
