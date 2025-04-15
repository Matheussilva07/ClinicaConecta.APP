using MongoDB.Driver;
using clinica.Domain.Entities;

namespace clinica.Infrastructure.DataAccess;
public class ClinicaDbContext
{
	private static string? _connection;
    public ClinicaDbContext(string connectionString)
    {
		_connection = connectionString;

	}
    public static MongoClient GetMongoClient()
	{	
		var client = new MongoClient(_connection);

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
