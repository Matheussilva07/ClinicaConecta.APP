using clinica.Domain.Entities;

namespace clinica.Domain.Repositories.Doutores;
public interface IWriteOnlyDoctorsRepository
{
	Task AddAsync(Doctor doutor);
	Task DeleteAsync(string id);
}
