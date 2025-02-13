using clinica.Domain.Entities;

namespace clinica.Domain.Repositories.Users;
public interface IWriteOnlyUserRepository
{
	Task AddAsync(User user);
}
