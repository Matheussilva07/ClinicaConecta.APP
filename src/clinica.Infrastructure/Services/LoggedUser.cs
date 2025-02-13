using clinica.Domain.Entities;
using clinica.Domain.Repositories.Users;
using clinica.Domain.Services.LoggedUser;
using clinica.Domain.Services.Token;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;

namespace clinica.Infrastructure.Services;
internal class LoggedUser : ILoggedUser
{
	private readonly ITokenProvider _tokenProvider;
	private readonly IReadOnlyUserRepository _readOnlyUserRepository;

	public LoggedUser(ITokenProvider tokenProvider, IReadOnlyUserRepository readOnlyUserRepository)
	{
		_tokenProvider = tokenProvider;
		_readOnlyUserRepository = readOnlyUserRepository;
	}

	public async Task<User> GetUser()
	{
		var token = _tokenProvider.GetTokenFromRequest();

		var tokenHandler = new JwtSecurityTokenHandler();

		var securityToken =	tokenHandler.ReadJwtToken(token);

		var userIdentifier = securityToken.Claims.First( claims => claims.Type == ClaimTypes.Sid).Value;

		return await _readOnlyUserRepository.GetUserByUserIdentifier(userIdentifier);
	}
}
