using clinica.Domain.Entities;

namespace clinica.Domain.Repositories.Doutores;
public interface IReadOnlyDoctorsRepository
{
	Task<List<Doctor>> GetAllAsync();

	Task<Doctor?> GetByName(string name);
}
