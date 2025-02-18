using clinica.Domain.Entities;
using clinica.Domain.Repositories.Consultas;
using clinica.Infrastructure.DataAccess;
using MongoDB.Driver;

namespace clinica.Infrastructure.Repositories.Consultas;
internal class ConsultasRepository : IWriteOnlyConsultasRepository
{
	private readonly IMongoCollection<Consulta> _consultas = ClinicaDbContext.GetConsultasCollection();

	public async Task AddAsync(Consulta consulta)
	{
		await _consultas.InsertOneAsync(consulta);
	}
}
