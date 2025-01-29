using clinica.Communication.Funcionarios.Requests;

namespace clinica.Application.FuncionariosUseCases.Update;
public interface IUpdateFuncionariosUseCase
{
	Task ExecuteAsync(RequestUpdateFuncionarioJson request,string id); 
}
