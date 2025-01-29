using clinica.Domain.Entities;

namespace clinica.Domain.Repositories.FuncionariosGerais;
public interface IWriteOnlyWorkersRepository
{
	Task AddAsync(Funcionario funcionarioGeral);
	Task DeleteAsync(string id);
}
