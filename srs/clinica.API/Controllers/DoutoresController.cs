using clinica.Application.Doctors.GetAll;
using clinica.Application.Doctors.Register;
using clinica.Communication.Doctors.Requests;
using clinica.Communication.Doctors.Responses;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace clinica.API.Controllers;

[Route("[controller]")]
[ApiController]
public class DoutoresController : ControllerBase
{
	[HttpPost]
	[ProducesResponseType(typeof(ResponseRegisteredDoctorJson), StatusCodes.Status201Created)]
	[ProducesResponseType(StatusCodes.Status400BadRequest)]
	public async Task<IActionResult> Register([FromServices] IRegisterDoctorUseCase useCase, [FromBody] RequestRegisterDoctorJson request)
	{
		var response = await useCase.ExecuteAsync(request);
		
		return Created(string.Empty, response);
	}

	[HttpGet]
	[ProducesResponseType(typeof(List<ResponseDoctorsListJson>), StatusCodes.Status200OK)]
	[ProducesResponseType(StatusCodes.Status204NoContent)]
	[ProducesResponseType(StatusCodes.Status400BadRequest)]
	public async Task<IActionResult> Register([FromServices] IGetAllDoctorsUseCase useCase )
	{
		var response = await useCase.ExecuteAsync();

		if (response.Count > 0)
			return Ok(response);
		return NoContent();
	}
}
