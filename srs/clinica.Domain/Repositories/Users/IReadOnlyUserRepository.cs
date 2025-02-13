using clinica.Domain.Entities;

namespace clinica.Domain.Repositories.Users;
public interface IReadOnlyUserRepository
{
	Task<bool> ExistUserWithThisEmail(string email);
	Task<User> GetUserByEmail(string email);
	Task<User> GetUserByUserIdentifier(string userIdentifier);
}
