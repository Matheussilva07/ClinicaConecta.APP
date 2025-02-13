namespace clinica.Domain.Security.Cryptography;
public interface IPasswordEncryptor
{
	string Encrypte(string password);	
	bool VerifyPassword(string passwordHash, string password);
}
