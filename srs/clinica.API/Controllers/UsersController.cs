using clinica.Application.UsersUseCases.Register;
using clinica.Communication.Users.Requests;
using clinica.Communication.Users.Responses;
using Microsoft.AspNetCore.Mvc;

namespace clinica.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class UsersController : ControllerBase
{
	[HttpPost]
	[ProducesResponseType(typeof(ResponseUserJson),StatusCodes.Status201Created)]
	[ProducesResponseType(StatusCodes.Status400BadRequest)]
	public async Task<IActionResult> Register([FromServices] IRegisterUserUseCase useCase, [FromBody] RequestRegisterUserJson request)
	{
		var response = await useCase.ExecuteAsync(request);
		
		return Created(string.Empty, response);
	}
}
