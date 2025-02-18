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
	public static IMongoCollection<Funcionario> GetFuncionariosCollection()
	{
		var client = GetMongoClient();

		var db = client.GetDatabase("Clinica_Conecta_DB");

		var collection = db.GetCollection<Funcionario>("funcionariosGerais");

		return collection;
	}
	public static IMongoCollection<Doctor> GetDoutoresCollection()
	{
		var client = GetMongoClient();

		var db = client.GetDatabase("Clinica_Conecta_DB");

		var collection = db.GetCollection<Doctor>("Doutores");

		return collection;
	}
	public static IMongoCollection<User> GetUsersCollection()
	{
		var client = GetMongoClient();

		var db = client.GetDatabase("Clinica_Conecta_DB");

		var collection = db.GetCollection<User>("Users");

		return collection;
	}
	public static IMongoCollection<Consulta> GetConsultasCollection()
	{
		var client = GetMongoClient();

		var db = client.GetDatabase("Clinica_Conecta_DB");

		var collection = db.GetCollection<Consulta>("Consultas");

		return collection;
	}
}
