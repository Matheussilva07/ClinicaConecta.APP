using clinica.Application.PacientesUseCases.Delete;
using clinica.Application.PacientesUseCases.GetAll;
using clinica.Application.PacientesUseCases.GetByName;
using clinica.Application.PacientesUseCases.Register;
using clinica.Application.PacientesUseCases.Update;
using clinica.Communication.Pacientes.Requests;
using clinica.Communication.Pacientes.Responses;
using clinica.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace clinica.API.Controllers;
[Route("[controller]")]
[ApiController]
public class PacientesController : ControllerBase
{
	[HttpPost("cadastro")]
	[ProducesResponseType(typeof(ResponseRegisteredPacienteJson),StatusCodes.Status201Created)]
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

	[HttpGet]
	[Route("{name}")]
	[ProducesResponseType(typeof(ResponsePacienteGettedByNameJson), StatusCodes.Status200OK)]
	[ProducesResponseType(StatusCodes.Status404NotFound)]
	[ProducesResponseType(StatusCodes.Status400BadRequest)]
	public async Task<IActionResult> GetByName([FromServices] IGetPacienteByNameUseCase useCase,[FromRoute] string name)
	{
		var response = await useCase.ExecuteAsync(name);
		
		return Ok(response);	
	}

	[HttpPut]
	[Route("{id}")]
	[ProducesResponseType(StatusCodes.Status204NoContent)]
	[ProducesResponseType(StatusCodes.Status404NotFound)]
	[ProducesResponseType(StatusCodes.Status400BadRequest)]
	public async Task<IActionResult> Update([FromServices] IUpdatePacienteUseCase useCase, [FromBody]RequestUpdatePacienteJson request, string id)
	{
		await useCase.ExecuteAsync(request,id);

		return NoContent();
	}

	[HttpDelete]
	[Route("{id}")]
	//[Authorize(Roles = "Apenas Administradores")]
	[ProducesResponseType(StatusCodes.Status204NoContent)]
	[ProducesResponseType(StatusCodes.Status404NotFound)]
	[ProducesResponseType(StatusCodes.Status400BadRequest)]
	public async Task<IActionResult> Delete([FromServices] IDeletePacienteUseCase useCase, [FromRoute] string id)
	{
		await useCase.ExecuteAsync(id);

		return NoContent();
	}
}
