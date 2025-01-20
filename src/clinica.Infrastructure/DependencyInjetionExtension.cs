using clinica.Domain.Repositories;
using clinica.Infrastructure.Repositories.FuncionariosGerais;
using Microsoft.Extensions.DependencyInjection;

namespace clinica.Infrastructure;
public static class DependencyInjetionExtension
{
	public static void AddInfrastructure(this IServiceCollection services)
	{
		AddDependencyInjection_Pacientes(services);
	}
	private static void AddDependencyInjection_Pacientes(IServiceCollection services)
	{
		services.AddScoped<IWriteOnly_Pacientes_Repository, PacientesRepository>();
		services.AddScoped<IReadOnly_Pacientes_Repository, PacientesRepository>();
		services.AddScoped<IUpdateOnly_Pacientes_Repository, PacientesRepository>();
	}
}
