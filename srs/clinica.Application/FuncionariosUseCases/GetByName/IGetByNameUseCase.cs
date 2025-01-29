using clinica.Communication.Funcionarios.Responses;

namespace clinica.Application.FuncionariosUseCases.GetByName;
public interface IGetByNameUseCase
{
	Task<ResponseWorkerJson> ExecuteAsync(string name);
}
