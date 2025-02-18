using AutoMapper;
using clinica.Communication.Consultas.Requests;
using clinica.Communication.Consultas.Responses;
using clinica.Communication.Doctors.Requests;
using clinica.Communication.Doctors.Responses;
using clinica.Communication.Funcionarios.Requests;
using clinica.Communication.Funcionarios.Responses;
using clinica.Communication.FuncionariosGerais.Requests;
using clinica.Communication.FuncionariosGerais.Responses;
using clinica.Communication.Pacientes.Requests;
using clinica.Communication.Pacientes.Responses;
using clinica.Communication.Users.Requests;
using clinica.Communication.Users.Responses;
using clinica.Domain.Entities;

namespace clinica.Application.Automapper;
public class Automapping : Profile
{
	public Automapping()
	{
		RequestToEntity_Pacientes();
		EntityToResponse_Pacientes();
		RequestToEntity_Funcionarios();
		EntityToResponse_Funcionarios();
		RequestToEntity_Doctors();
		EntityToResponse_Doctors();
		RequestoToEntity_Users();
		EntityToResponse_Users();
		RequestToEntity_Consultas();
		EntityToResponse_Consultas();
	}

	#region Automapper para pacientes
	private void RequestToEntity_Pacientes()
	{
		CreateMap<RequestRegisterPacienteJson, Paciente>();
		CreateMap<RequestUpdatePacienteJson, Paciente>();
	}
	private void EntityToResponse_Pacientes()
	{
		CreateMap<Paciente, ResponseRegisteredPacienteJson>();
		CreateMap<Paciente, ResponseRegisteredPacienteJson>();
		CreateMap<Paciente, ResponsePacienteGettedByNameJson>();
	}

	#endregion

	#region Automapper para funcionários
	private void RequestToEntity_Funcionarios()
	{
		CreateMap<RequestRegisterFuncionarioJson, Funcionario>();
		CreateMap<RequestUpdateFuncionarioJson, Funcionario>();
	}
	private void EntityToResponse_Funcionarios()
	{
		CreateMap<Funcionario, ResponseRegisteredFuncionarioJson>();
		CreateMap<Funcionario, ResponseShortFuncionarioJson>();
		CreateMap<Funcionario, ResponseWorkerJson>();
	}
	#endregion

	#region Automapper para doutores
	private void RequestToEntity_Doctors()
	{
		CreateMap<RequestRegisterDoctorJson, Doctor>();
		CreateMap<RequestUpdateDoctorJson, Doctor>();
	}
	private void EntityToResponse_Doctors()
	{
		CreateMap<Doctor, ResponseRegisteredDoctorJson>();
		CreateMap<Doctor, ResponseDoctorsJson>();
	}
	#endregion

	#region Automapper para users

	private void RequestoToEntity_Users()
	{
		CreateMap<RequestRegisterUserJson, User>().ForMember(user => user.Password, mapper => mapper.Ignore());
	}

	private void EntityToResponse_Users()
	{
		CreateMap<User, ResponseUserJson>();
	}

	#endregion

	#region Automapper para consultas

	private void RequestToEntity_Consultas()
	{
		CreateMap<RequestRegisterConsultaJson, Consulta>();
	}
	private void EntityToResponse_Consultas()
	{
		CreateMap<Consulta, ResponseRegisteredConsultaJson>();
	}

	#endregion
}
