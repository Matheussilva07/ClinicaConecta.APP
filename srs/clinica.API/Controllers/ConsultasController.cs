using clinica.Application.ConsultasUseCases.Register;
using clinica.Communication.Consultas.Requests;
using clinica.Communication.Consultas.Responses;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace clinica.API.Controllers;

[Route("[controller]")]
[ApiController]
public class ConsultasController : ControllerBase
{
	[HttpPost]
	[ProducesResponseType(typeof(ResponseRegisteredConsultaJson),StatusCodes.Status201Created)]
	[ProducesResponseType(StatusCodes.Status400BadRequest)]
	public async Task<IActionResult> Register([FromServices] IRegisterConsultaUseCase useCase , [FromBody] RequestRegisterConsultaJson request)
	{
		var response = await useCase.ExecuteAsync(request);
		
		return Created(string.Empty, response);
	}
}
