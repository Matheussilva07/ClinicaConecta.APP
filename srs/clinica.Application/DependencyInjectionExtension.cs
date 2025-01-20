using clinica.Application.Automapper;
using clinica.Application.PacientesUseCases.GetAll;
using clinica.Application.PacientesUseCases.Register;
using clinica.Application.PacientesUseCases.Update;
using Microsoft.Extensions.DependencyInjection;

namespace clinica.Application;
public static class DependencyInjectionExtension
{
	public static void AddInstrastructure_Application(this IServiceCollection services)
	{
		AddAutoMapper(services);
		AddDependencyInjection(services);
	}
	private static void AddDependencyInjection(IServiceCollection services)
	{
		services.AddScoped<IRegisterPacienteUseCase, RegisterPacienteUseCase>();
		services.AddScoped<IGetAllPacientesUseCase, GetAllPacientesUseCase>();
		services.AddScoped<IUpdatePacienteUseCase, UpdatePacienteUseCase>();
	}
	private static void AddAutoMapper(IServiceCollection services)
	{
		services.AddAutoMapper(typeof(Automapping));
	}
}
