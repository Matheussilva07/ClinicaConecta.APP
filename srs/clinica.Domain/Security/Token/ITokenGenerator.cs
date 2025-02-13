using clinica.Domain.Entities;

namespace clinica.Domain.Security.Token;
public interface ITokenGenerator
{
	string GenerateToken(User user);
}
