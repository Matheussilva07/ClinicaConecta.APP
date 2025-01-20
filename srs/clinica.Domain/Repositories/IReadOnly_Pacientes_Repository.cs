using clinica.Domain.Entities;

namespace clinica.Domain.Repositories;
public interface IReadOnly_Pacientes_Repository
{
	Task<List<Paciente>> GetAllAsync();
}
