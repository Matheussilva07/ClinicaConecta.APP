using clinica.Communication.Pacientes.Requests;
using clinica.Communication.Pacientes.Responses;

namespace clinica.Application.PacientesUseCases.Register;
public interface IRegisterPacienteUseCase
{
	Task<ResponseRegisteredPacienteJson> ExecuteAsync(RequestRegisterPacienteJson request);
}
