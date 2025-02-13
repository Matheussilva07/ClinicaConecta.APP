using clinica.Domain.Services.Token;

namespace clinica.API.Token;

public class HttpContextAccessor : ITokenProvider
{
	private readonly IHttpContextAccessor _contextAccessor;

	public HttpContextAccessor(IHttpContextAccessor contextAccessor)
	{
		_contextAccessor = contextAccessor;
	}

	public string GetTokenFromRequest()
	{
		var authorization = _contextAccessor.HttpContext!.Request.Headers.Authorization.ToString();

		return authorization["Bearer ".Length..];
	}
}
