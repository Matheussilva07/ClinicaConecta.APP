using clinica.Domain.Entities;

namespace clinica.Domain.Services.LoggedUser;
public interface ILoggedUser
{
	Task<User> GetUser();
}
