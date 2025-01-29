using clinica.Communication.FuncionariosGerais.Requests;
using clinica.Communication.FuncionariosGerais.Responses;

namespace clinica.Application.FuncionariosUseCases.Register;
public interface IRegisterFuncionarioUseCase
{
    Task<ResponseRegisteredFuncionarioJson> ExecuteAsync(RequestRegisterFuncionarioJson request);
}
