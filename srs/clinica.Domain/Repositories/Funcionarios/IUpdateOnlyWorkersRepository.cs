using clinica.Domain.Entities;

namespace clinica.Domain.Repositories.Funcionarios;
public interface IUpdateOnlyWorkersRepository
{
	Task UpdateAsync(Funcionario funcionario, string id);
}
