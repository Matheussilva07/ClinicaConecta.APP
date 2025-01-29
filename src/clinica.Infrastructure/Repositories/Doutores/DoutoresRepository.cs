using clinica.Domain.Entities;
using clinica.Domain.Repositories.Doutores;
using clinica.Infrastructure.DataAccess;
using MongoDB.Driver;

namespace clinica.Infrastructure.Repositories.Doutores;
internal class DoutoresRepository : IWriteOnlyDoctorsRepository, IReadOnlyDoctorsRepository
{
	private readonly IMongoCollection<Doctor> _doutores = ClinicaDbContext.GetDoutoresCollectionID();

	public async Task AddAsync(Doctor doutor)
	{
		await _doutores.InsertOneAsync(doutor);
	}

	public async Task<List<Doctor>> GetAllAsync()
	{
		return await _doutores.Find(_=> true).ToListAsync();
	}
}
