using clinica.Domain.Entities;

namespace clinica.Domain.Repositories.FuncionariosGerais;
public interface IReadOnlyWorkersRepository
{
	Task<List<Funcionario>> GetAllAsync();

	Task<Funcionario?> GetByName(string name);

}
