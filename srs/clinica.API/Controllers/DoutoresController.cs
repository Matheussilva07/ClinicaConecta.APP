using clinica.Application.Doctors.GetAll;
using clinica.Application.Doctors.GetByName;
using clinica.Application.Doctors.Register;
using clinica.Application.Doctors.Update;
using clinica.Application.DoctorsUseCases.Delete;
using clinica.Communication.Doctors.Requests;
using clinica.Communication.Doctors.Responses;
using Microsoft.AspNetCore.Mvc;

namespace clinica.API.Controllers;

[Route("[controller]")]
[ApiController]
public class DoutoresController : ControllerBase
{
	[HttpPost("register")]
	[ProducesResponseType(typeof(ResponseRegisteredDoctorJson), StatusCodes.Status201Created)]
	[ProducesResponseType(StatusCodes.Status400BadRequest)]
	public async Task<IActionResult> Register([FromServices] IRegisterDoctorUseCase useCase, [FromBody] RequestRegisterDoctorJson request)
	{
		var response = await useCase.ExecuteAsync(request);

		return Created(string.Empty, response);
	}

	[HttpGet("list")]
	[ProducesResponseType(typeof(List<ResponseDoctorsJson>), StatusCodes.Status200OK)]
	[ProducesResponseType(StatusCodes.Status204NoContent)]
	[ProducesResponseType(StatusCodes.Status400BadRequest)]
	public async Task<IActionResult> GetAll([FromServices] IGetAllDoctorsUseCase useCase)
	{
		var response = await useCase.ExecuteAsync();

		if (response.Count > 0)
			return Ok(response);
		return NoContent();
	}

	[HttpGet]
	[Route("by-name-{name}")]
	[ProducesResponseType(typeof(ResponseDoctorsJson), StatusCodes.Status200OK)]
	[ProducesResponseType(StatusCodes.Status404NotFound)]
	[ProducesResponseType(StatusCodes.Status400BadRequest)]
	public async Task<IActionResult> GetByName([FromServices] IGetDoctorByNameUseCase useCase, [FromRoute] string name)
	{
		var response = await useCase.ExecuteAsync(name);

		return Ok(response);
	}

	[HttpPut]
	[Route("update-{id}")]
	[ProducesResponseType(StatusCodes.Status204NoContent)]
	[ProducesResponseType(StatusCodes.Status404NotFound)]
	[ProducesResponseType(StatusCodes.Status400BadRequest)]
	public async Task<IActionResult> Update([FromServices] IUpdateDoctorUseCase useCase, [FromBody] RequestUpdateDoctorJson request, [FromRoute] string id)
	{
		await useCase.ExecuteAsync(request, id);

		return NoContent();
	}

	[HttpDelete]
	[Route("delete-{id}")]
	[ProducesResponseType(StatusCodes.Status204NoContent)]
	[ProducesResponseType(StatusCodes.Status404NotFound)]
	[ProducesResponseType(StatusCodes.Status400BadRequest)]
	public async Task<IActionResult> Delete([FromServices] IDeleteDoctorUseCase useCase, [FromRoute] string id)
	{
		await useCase.ExecuteAsync(id);

		return NoContent();
	}
}
