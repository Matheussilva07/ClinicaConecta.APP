using AutoMapper;
using clinica.Communication.Pacientes.Requests;
using clinica.Communication.Pacientes.Responses;
using clinica.Domain.Entities;

namespace clinica.Application.Automapper;
public class Automapping : Profile
{
	public Automapping()
	{
		RequestToEntity();
		EntityToResponse();
	}

	private void RequestToEntity()
	{
		CreateMap<RequestRegisterPacienteJson, Paciente>();
		CreateMap<RequestUpdatePacienteJson, Paciente>();
	}
	private void EntityToResponse()
	{
		CreateMap<Paciente, ResponseRegisteredPacinteJson>();
	}
}
