using clinica.Domain.Entities;
using clinica.Domain.Repositories.Funcionarios;
using clinica.Domain.Repositories.FuncionariosGerais;
using clinica.Infrastructure.DataAccess;
using MongoDB.Driver;

namespace clinica.Infrastructure.Repositories.FuncionariosGerais;
internal class FuncionariosRepository : IWriteOnlyWorkersRepository, IReadOnlyWorkersRepository, IUpdateOnlyWorkersRepository
{

	private readonly IMongoCollection<Funcionario> _funcionarios = ClinicaDbContext.GetFuncionariosCollection();

	public async Task AddAsync(Funcionario funcionarioGeral)
	{
		await _funcionarios.InsertOneAsync(funcionarioGeral);
	}

	public async Task<List<Funcionario>> GetAllAsync()
	{
		return await _funcionarios.Find(_ => true).ToListAsync();
	}

	public async Task UpdateAsync(Funcionario funcionario, string id)
	{
		var filter = Builders<Funcionario>.Filter.Eq(f => f.Id, id);

		var request = Builders<Funcionario>.Update
			.Set(p => p.Name, funcionario.Name)
			.Set(p => p.Email, funcionario.Email)
			.Set(p => p.Cpf, funcionario.Cpf)
			.Set(p => p.Rg, funcionario.Rg)
			.Set(p => p.Address, funcionario.Address)
			.Set(p => p.Telephone, funcionario.Telephone)
			.Set(p => p.Function, funcionario.Function)
			.Set(p => p.Date_Hire, funcionario.Date_Hire)
			.Set(p => p.Date_Fire, funcionario.Date_Fire)
			.Set(p => p.Contract_Type, funcionario.Contract_Type)
			.Set(p => p.Work_hours, funcionario.Work_hours)
			.Set(p => p.BankAccount, funcionario.BankAccount);


		UpdateResult result = await _funcionarios.UpdateOneAsync(filter, request);
	}

	public async Task DeleteAsync(string id)
	{
		var filter = Builders<Funcionario>.Filter.Eq(f => f.Id, id);

		await _funcionarios.FindOneAndDeleteAsync(filter);
	}

	public async Task<Funcionario?> GetByName(string name)
	{
		var filter = Builders<Funcionario>.Filter.Regex(p => p.Name, new MongoDB.Bson.BsonRegularExpression($"^{name}", "i"));

		var result = await _funcionarios.FindAsync(filter);

		var funcionario = await result.FirstOrDefaultAsync();

		return funcionario;
	}
}
