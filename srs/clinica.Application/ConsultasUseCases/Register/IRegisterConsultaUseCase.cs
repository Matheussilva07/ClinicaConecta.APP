using clinica.Communication.Consultas.Requests;
using clinica.Communication.Consultas.Responses;

namespace clinica.Application.ConsultasUseCases.Register;
public interface IRegisterConsultaUseCase
{
	Task<ResponseRegisteredConsultaJson> ExecuteAsync(RequestRegisterConsultaJson request);
}
