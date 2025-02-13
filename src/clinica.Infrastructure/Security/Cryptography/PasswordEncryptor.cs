using clinica.Domain.Security.Cryptography;
using BC = BCrypt.Net.BCrypt;

namespace clinica.Infrastructure.Security.Cryptography;
internal class PasswordEncryptor : IPasswordEncryptor
{
	public string Encrypte(string password)
	{
		string passwordHash = BC.HashPassword(password);

		return passwordHash;
	}

	public bool VerifyPassword(string passwordHash, string password)
	{
		return BC.Verify(passwordHash,password);
	}
}
