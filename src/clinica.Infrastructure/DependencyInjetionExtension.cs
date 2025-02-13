using clinica.Domain.Repositories.Doutores;
using clinica.Domain.Repositories.Funcionarios;
using clinica.Domain.Repositories.FuncionariosGerais;
using clinica.Domain.Repositories.Pacientes;
using clinica.Domain.Repositories.Users;
using clinica.Domain.Security.Cryptography;
using clinica.Domain.Security.Token;
using clinica.Infrastructure.Repositories.Doutores;
using clinica.Infrastructure.Repositories.FuncionariosGerais;
using clinica.Infrastructure.Repositories.Users;
using clinica.Infrastructure.Security.Cryptography;
using clinica.Infrastructure.Security.Token;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace clinica.Infrastructure;
public static class DependencyInjetionExtension
{
	public static void AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
	{
		AddDependencyInjection_Pacientes(services);
		AddDependencyInjection_Funcionarios(services);
		AddDependencyInjection_Doutores(services);
		AddDependencyInjection_Users(services);
		AddTokenGenerator(services, configuration);

	}
	private static void AddDependencyInjection_Pacientes(IServiceCollection services)
	{
		services.AddScoped<IWriteOnlyPacientesRepository, PacientesRepository>();
		services.AddScoped<IReadOnlyPacientesRepository, PacientesRepository>();
		services.AddScoped<IUpdateOnlyPacientesRepository, PacientesRepository>();
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
		services.AddScoped<IUpdateOnlyDoctorRepository, DoutoresRepository>();
	
	}
	private static void AddDependencyInjection_Users(IServiceCollection services)
	{
		services.AddScoped<IWriteOnlyUserRepository, UsersRepository>();
		services.AddScoped<IReadOnlyUserRepository, UsersRepository>();

		services.AddScoped<IPasswordEncryptor, PasswordEncryptor>();
	}

	private static void AddTokenGenerator(IServiceCollection services, IConfiguration configuration)
	{
		string signingKey = configuration.GetValue<string>("Settings:Jwt:SigningKey")!;
		int expiresMinutes = configuration.GetValue<int>("Settings:Jwt:ExpiresMinutes");

		services.AddScoped<ITokenGenerator>( config => new TokenGenerator(signingKey, expiresMinutes));
	}
}
