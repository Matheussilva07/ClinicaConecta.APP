using clinica.Domain.Entities;
using clinica.Domain.Repositories.Pacientes;
using clinica.Infrastructure.DataAccess;
using MongoDB.Driver;

namespace clinica.Infrastructure.Repositories.FuncionariosGerais;
internal class PacientesRepository : IWriteOnlyPacientesRepository, IReadOnlyPacientesRepository, IUpdateOnlyPacientesRepository
{

	private readonly IMongoCollection<Paciente> _pacientes = ClinicaDbContext.GetPacientesCollection();

	public async Task AddAsync(Paciente paciente)
	{
		await _pacientes.InsertOneAsync(paciente);
	}
	public async Task<List<Paciente>> GetAllAsync()
	{
		var pacientesLista = await _pacientes.Find(_=> true).ToListAsync();

		return pacientesLista;
	}
	public async Task<bool> UpdateAsync(Paciente paciente, string id)
	{
		var filter = Builders<Paciente>.Filter.Eq(p => p.Id, id);

		var update = Builders<Paciente>.Update
			.Set(p => p.Name, paciente.Name)
			.Set(p => p.Email, paciente.Email)
			.Set(p => p.CPF, paciente.CPF)
			.Set(p => p.Telephone, paciente.Telephone)
			.Set(p => p.Address, paciente.Address)
			.Set(p => p.Birth, paciente.Birth);


		UpdateResult result = await _pacientes.UpdateOneAsync(filter, update);

		return result.IsAcknowledged;
	}
	public async Task DeleteAsync(string id)
	{
		var filter = Builders<Paciente>.Filter.Eq(paciente => paciente.Id, id);

		await _pacientes.DeleteOneAsync(filter);
	}
	public async Task<Paciente?> GetByName(string name)
	{
		var filter = Builders<Paciente>.Filter.Regex(p => p.Name, new MongoDB.Bson.BsonRegularExpression($"^{name}", "i"));

		var result = await _pacientes.FindAsync(filter);

		var paciente = await result.FirstOrDefaultAsync();

		return paciente;
	}
}
