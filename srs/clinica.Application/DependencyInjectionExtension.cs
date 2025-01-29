using clinica.Application.Automapper;
using clinica.Application.Doctors.GetAll;
using clinica.Application.Doctors.Register;
using clinica.Application.FuncionariosUseCases.Delete;
using clinica.Application.FuncionariosUseCases.GetAll;
using clinica.Application.FuncionariosUseCases.GetByName;
using clinica.Application.FuncionariosUseCases.Register;
using clinica.Application.FuncionariosUseCases.Update;
using clinica.Application.PacientesUseCases.Delete;
using clinica.Application.PacientesUseCases.GetAll;
using clinica.Application.PacientesUseCases.GetByName;
using clinica.Application.PacientesUseCases.Register;
using clinica.Application.PacientesUseCases.Update;
using Microsoft.Extensions.DependencyInjection;

namespace clinica.Application;
public static class DependencyInjectionExtension
{
	public static void AddInstrastructure_Application(this IServiceCollection services)
	{
		AddAutoMapper(services);
		AddDependencyInjectionPacients(services);
		AddDependencyInjectionWorkers(services);
		AddDependencyInjectionDoctors(services);
	}
	private static void AddDependencyInjectionPacients(IServiceCollection services)
	{
		services.AddScoped<IRegisterPacienteUseCase, RegisterPacienteUseCase>();
		services.AddScoped<IGetAllPacientesUseCase, GetAllPacientesUseCase>();
		services.AddScoped<IGetPacienteByNameUseCase, GetPacienteByNameUseCase>();
		services.AddScoped<IUpdatePacienteUseCase, UpdatePacienteUseCase>();
		services.AddScoped<IDeletePacienteUseCase, DeletePacienteUseCase>();
	}
	private static void AddAutoMapper(IServiceCollection services)
	{
		services.AddAutoMapper(typeof(Automapping));
	}

	private static void AddDependencyInjectionWorkers(IServiceCollection services)
	{
		services.AddScoped<IRegisterFuncionarioUseCase, RegisterFuncionarioUseCase>();		
		services.AddScoped<IGetAllFuncionariosUseCase, GetAllFuncionariosUseCase>();		
		services.AddScoped<IGetByNameUseCase, GetByNameUseCase>();		
		services.AddScoped<IUpdateFuncionariosUseCase, UpdateFuncionariosUseCase>();		
		services.AddScoped<IDeleteFuncionarioUseCase, DeleteFuncionarioUseCase>();		
	}
	private static void AddDependencyInjectionDoctors(IServiceCollection services)
	{
		services.AddScoped<IRegisterDoctorUseCase, RegisterDoctorUseCase>();
		services.AddScoped<IGetAllDoctorsUseCase, GetAllDoctorsUseCase>();

	}
}
