using clinica.Domain.Repositories.FuncionariosGerais;

namespace clinica.Application.FuncionariosUseCases.Delete;
internal class DeleteFuncionarioUseCase : IDeleteFuncionarioUseCase
{
	private readonly IWriteOnlyWorkersRepository _repository;

	public DeleteFuncionarioUseCase(IWriteOnlyWorkersRepository repository)
	{
		_repository = repository;
	}

	public async Task ExecuteAsync(string id)
	{		
		if(string.IsNullOrWhiteSpace(id))
		{
			throw new ArgumentException("Funcionário não encontrado!");
		}

		await _repository.DeleteAsync(id);		
	}
}
