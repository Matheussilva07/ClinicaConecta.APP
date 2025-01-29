using clinica.Communication.Funcionarios.Responses;

namespace clinica.Application.FuncionariosUseCases.GetAll;
public interface IGetAllFuncionariosUseCase
{
	Task<List<ResponseShortFuncionarioJson>> ExecuteAsync();
}
