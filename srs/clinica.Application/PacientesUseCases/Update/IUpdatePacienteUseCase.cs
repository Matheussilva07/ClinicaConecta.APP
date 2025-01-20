using clinica.Communication.Pacientes.Requests;

namespace clinica.Application.PacientesUseCases.Update;
public interface IUpdatePacienteUseCase
{
	Task ExecuteAsync(RequestUpdatePacienteJson request, string name);
}
