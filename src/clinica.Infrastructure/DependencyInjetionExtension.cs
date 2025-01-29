using clinica.Domain.Repositories.Doutores;
using clinica.Domain.Repositories.Funcionarios;
using clinica.Domain.Repositories.FuncionariosGerais;
using clinica.Domain.Repositories.Pacientes;
using clinica.Infrastructure.Repositories.Doutores;
using clinica.Infrastructure.Repositories.FuncionariosGerais;
using Microsoft.Extensions.DependencyInjection;

namespace clinica.Infrastructure;
public static class DependencyInjetionExtension
{
	public static void AddInfrastructure(this IServiceCollection services)
	{
		AddDependencyInjection_Pacientes(services);
		AddDependencyInjection_Funcionarios(services);
		AddDependencyInjection_Doutores(services);

	}
	private static void AddDependencyInjection_Pacientes(IServiceCollection services)
	{
		services.AddScoped<IWriteOnly_Pacientes_Repository, PacientesRepository>();
		services.AddScoped<IReadOnly_Pacientes_Repository, PacientesRepository>();
		services.AddScoped<IUpdateOnly_Pacientes_Repository, PacientesRepository>();
	}
	private static void AddDependencyInjection_Funcionarios(IServiceCollection services)
	{
		services.AddScoped<IWriteOnlyWorkersRepository, FuncionariosRepository>();
		services.AddScoped<IReadOnlyWorkersRepository, FuncionariosRepository>();
		services.AddScoped<IUpdateOnlyWorkersRepository, FuncionariosRepository>();
	}
	private static void AddDependencyInjection_Doutores(IServiceCollection services)
	{
		services.AddScoped<IWriteOnlyDoctorsRepository, DoutoresRepository>();
		services.AddScoped<IReadOnlyDoctorsRepository, DoutoresRepository>();
	
	}
}
