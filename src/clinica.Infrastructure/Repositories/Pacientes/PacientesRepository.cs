using clinica.Domain.Entities;
using clinica.Domain.Repositories;
using clinica.Infrastructure.DataAccess;
using MongoDB.Driver;

namespace clinica.Infrastructure.Repositories.FuncionariosGerais;
internal class PacientesRepository : IWriteOnly_Pacientes_Repository, IReadOnly_Pacientes_Repository, IUpdateOnly_Pacientes_Repository
{
	private readonly IMongoCollection<Paciente> pacientes = ClinicaDbContext.GetPacientesCollection();

	public async Task AddAsync(Paciente paciente)
	{
		await pacientes.InsertOneAsync(paciente);
	}
	public async Task<List<Paciente>> GetAllAsync()
	{
		var filtro = Builders<Paciente>.Filter.Empty;

		var projeto = Builders<Paciente>.Projection.Exclude("_id");

		var pacientesLista = await pacientes.Find(filtro).Project<Paciente>(projeto).ToListAsync();

		return pacientesLista;
	}
	public async Task<bool> UpdateAsync(Paciente paciente, string name)
	{
		//var filter = Builders<Paciente>.Filter.Empty;

		var filter = Builders<Paciente>.Filter.Eq(p => p.Name, name);

		var update = Builders<Paciente>.Update
			.Set(p => p.Name, paciente.Name)
			.Set(p => p.Email, paciente.Address)
			.Set(p => p.Telephone, paciente.Telephone)
			.Set(p => p.Address, paciente.Address)
			.Set(p => p.Birth, paciente.Birth);


		UpdateResult result = await pacientes.UpdateOneAsync(filter, update);

		return result.IsAcknowledged;
	}
}
