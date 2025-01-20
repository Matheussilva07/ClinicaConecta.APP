using MongoDB.Driver;
using clinica.Domain.Entities;

namespace clinica.Infrastructure.DataAccess;
internal class ClinicaDbContext
{
	private static MongoClient GetMongoClient()
	{
		const string connectionString = "mongodb+srv://Matheus:Kundschafter1996@datahaven.atinz.mongodb.net/?retryWrites=true&w=majority&appName=DataHaven";
		
		var client = new MongoClient(connectionString);

		return client;
	}

	public static IMongoCollection<Paciente> GetPacientesCollection()
	{
		var client = GetMongoClient();

		var db = client.GetDatabase("Clinica_Conecta_DB");

		var collection = db.GetCollection<Paciente>("Pacientes");

		return collection;
	}
}
