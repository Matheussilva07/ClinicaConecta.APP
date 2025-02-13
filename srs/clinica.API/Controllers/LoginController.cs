using clinica.Application.DoLoginUseCase;
using clinica.Communication.Users.Requests;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace clinica.API.Controllers;
[Route("api/[controller]")]
[ApiController]
public class LoginController : ControllerBase
{
	[HttpPost]
	[ProducesResponseType(typeof(string), StatusCodes.Status200OK)]
	[ProducesResponseType(StatusCodes.Status400BadRequest)]
	public async Task<IActionResult> DoLogin([FromServices] IDoLoginUserUseCase useCase, [FromBody]RequestDoLoginJson request)
	{
		var response = await useCase.ExecuteAsync(request);
		
		return Ok(response);
	}
}
