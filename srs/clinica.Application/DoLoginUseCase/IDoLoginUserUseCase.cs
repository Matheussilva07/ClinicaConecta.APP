using clinica.Communication.Users.Requests;
using clinica.Communication.Users.Responses;

namespace clinica.Application.DoLoginUseCase;
public interface IDoLoginUserUseCase
{
	Task<ResponseUserJson> ExecuteAsync(RequestDoLoginJson request);
}
