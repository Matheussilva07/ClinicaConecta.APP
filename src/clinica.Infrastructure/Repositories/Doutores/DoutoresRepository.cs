using clinica.Domain.Entities;
using clinica.Domain.Repositories.Doutores;
using clinica.Infrastructure.DataAccess;
using MongoDB.Driver;

namespace clinica.Infrastructure.Repositories.Doutores;
internal class DoutoresRepository : IWriteOnlyDoctorsRepository, IReadOnlyDoctorsRepository, IUpdateOnlyDoctorRepository
{
	private readonly IMongoCollection<Doctor> _doutores = ClinicaDbContext.GetDoutoresCollection();

	public async Task AddAsync(Doctor doutor)
	{
		await _doutores.InsertOneAsync(doutor);
	}
	public async Task<List<Doctor>> GetAllAsync()
	{
		return await _doutores.Find(_=> true).ToListAsync();
	}
	public async Task<Doctor?> GetByName(string name)
	{
		var filter = Builders<Doctor>.Filter.Regex(p => p.Name, new MongoDB.Bson.BsonRegularExpression($"^{name}", "i"));

		var result = await _doutores.FindAsync(filter);

		var doctor = await result.FirstOrDefaultAsync();

		return doctor;
	}
	public async Task<bool> Update(Doctor doctor, string id)
	{
		var filter = Builders<Doctor>.Filter.Eq(p => p.Id, id);

		var update = Builders<Doctor>.Update
			.Set(d => d.Name, doctor.Name)
			.Set(d => d.Email, doctor.Email)
			.Set(d => d.Cpf, doctor.Cpf)
			.Set(d => d.Rg, doctor.Rg)
			.Set(d => d.Address, doctor.Address)
			.Set(d => d.Telephone, doctor.Telephone)
			.Set(d => d.Expertise, doctor.Expertise)
			.Set(d => d.Date_Hire, doctor.Date_Hire)
			.Set(d => d.Date_Fire, doctor.Date_Fire)
			.Set(d => d.Value, doctor.Value)
			.Set(d => d.Expiration, doctor.Expiration)
			.Set(d => d.Sessions, doctor.Sessions)
			.Set(d => d.Work_hours, doctor.Work_hours)
			.Set(d => d.Turns, doctor.Turns)
			.Set(d => d.BankAccount, doctor.BankAccount);

		UpdateResult updateResult = await _doutores.UpdateOneAsync(filter, update);

		return updateResult.IsAcknowledged;
	}
	public async Task DeleteAsync(string id)
	{
		var filter = Builders<Doctor>.Filter.Eq(doctor => doctor.Id, id);

		await _doutores.DeleteOneAsync(filter);
	}
}
