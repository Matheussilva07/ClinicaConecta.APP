using clinica.Domain.Entities;
using clinica.Domain.Security.Token;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace clinica.Infrastructure.Security.Token;
internal class TokenGenerator : ITokenGenerator
{
	private readonly string _signingKey;
	private readonly int _expirationTimeMinutes;

	public TokenGenerator(string signingKey, int expirationTimeMinutes)
	{
		_signingKey = signingKey;
		_expirationTimeMinutes = expirationTimeMinutes;
	}

	public string GenerateToken(User user)
	{
		List<Claim> claims =
		[
			new(ClaimTypes.Name, user.Name),
			new(ClaimTypes.Sid, user.UserIdentifier.ToString()),
			new(ClaimTypes.Role, user.Role)
		];

		var tokenDescryptor = new SecurityTokenDescriptor
		{
			Expires = DateTime.UtcNow.AddMinutes(_expirationTimeMinutes),
			SigningCredentials = new SigningCredentials(GetSecurityKey(), SecurityAlgorithms.HmacSha256Signature),
			Subject = new ClaimsIdentity(claims)
		};

		var tokenHandler = new JwtSecurityTokenHandler();

		var token = tokenHandler.CreateToken(tokenDescryptor);

		return tokenHandler.WriteToken(token);
	}

	private SymmetricSecurityKey GetSecurityKey()
	{
		var key = Encoding.UTF8.GetBytes(_signingKey);

		return new SymmetricSecurityKey(key);
	}
}
