using clinica.Communication.Pacientes.Responses;

namespace clinica.Application.PacientesUseCases.GetByName;
public interface IGetPacienteByNameUseCase
{
	Task<ResponsePacienteGettedByNameJson?> ExecuteAsync(string name);
}
