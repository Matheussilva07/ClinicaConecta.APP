using clinica.Domain.Entities;

namespace clinica.Domain.Repositories.Consultas;
public interface IWriteOnlyConsultasRepository
{
	Task AddAsync(Consulta consulta);
}
