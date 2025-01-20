using clinica.Application.PacientesUseCases.GetAll;
using clinica.Application.PacientesUseCases.Register;
using clinica.Application.PacientesUseCases.Update;
using clinica.Communication.Pacientes.Requests;
using clinica.Communication.Pacientes.Responses;
using clinica.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace clinica.API.Controllers;
[Route("api/[controller]")]
[ApiController]
public class PacientesController : ControllerBase
{
	[HttpPost]
	[ProducesResponseType(typeof(ResponseRegisteredPacinteJson),StatusCodes.Status201Created)]
	[ProducesResponseType(StatusCodes.Status400BadRequest)]
	public async Task<IActionResult> Register([FromServices] IRegisterPacienteUseCase useCase, [FromBody] RequestRegisterPacienteJson request)
	{
		var response = await useCase.ExecuteAsync(request);

		return Created(string.Empty, response);
	}

	[HttpGet]
	[ProducesResponseType(typeof(List<Paciente>), StatusCodes.Status200OK)]
	[ProducesResponseType(StatusCodes.Status204NoContent)]
	public async Task<IActionResult> GetAll([FromServices] IGetAllPacientesUseCase useCase)
	{
		var response = await useCase.ExecuteAsync();

		if (response.Count > 0)
			return Ok(response);
		return NoContent();
	}

	[HttpPut]
	[Route("{name}")]
	[ProducesResponseType(StatusCodes.Status204NoContent)]
	[ProducesResponseType(StatusCodes.Status404NotFound)]
	[ProducesResponseType(StatusCodes.Status400BadRequest)]
	public async Task<IActionResult> Update([FromServices] IUpdatePacienteUseCase useCase, [FromBody]RequestUpdatePacienteJson request, string name)
	{
		await useCase.ExecuteAsync(request: request,name: name);

		return NoContent();
	}
}
