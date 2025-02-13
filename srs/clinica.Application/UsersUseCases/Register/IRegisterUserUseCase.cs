using clinica.Communication.Users.Requests;
using clinica.Communication.Users.Responses;

namespace clinica.Application.UsersUseCases.Register;
public interface IRegisterUserUseCase
{
	Task<ResponseUserJson> ExecuteAsync(RequestRegisterUserJson request);
}
