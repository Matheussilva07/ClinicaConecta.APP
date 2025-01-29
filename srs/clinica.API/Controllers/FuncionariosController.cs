using clinica.Application.FuncionariosUseCases.Delete;
using clinica.Application.FuncionariosUseCases.GetAll;
using clinica.Application.FuncionariosUseCases.GetByName;
using clinica.Application.FuncionariosUseCases.Register;
using clinica.Application.FuncionariosUseCases.Update;
using clinica.Communication.Funcionarios.Requests;
using clinica.Communication.Funcionarios.Responses;
using clinica.Communication.FuncionariosGerais.Requests;
using clinica.Communication.FuncionariosGerais.Responses;
using clinica.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace clinica.API.Controllers;

[Route("[controller]")]
[ApiController]
public class FuncionariosController : ControllerBase
{
	[HttpPost]
	[ProducesResponseType(typeof(ResponseRegisteredFuncionarioJson), StatusCodes.Status201Created)]
	[ProducesResponseType(StatusCodes.Status400BadRequest)]
	public async Task<IActionResult> Register([FromServices] IRegisterFuncionarioUseCase useCase, [FromBody] RequestRegisterFuncionarioJson request)
	{
		var response = await useCase.ExecuteAsync(request);

		return Created(string.Empty, response);
	}

	[HttpGet]
	[ProducesResponseType(typeof(ResponseShortFuncionarioJson), StatusCodes.Status200OK)]
	[ProducesResponseType(StatusCodes.Status204NoContent)]
	[ProducesResponseType(StatusCodes.Status400BadRequest)]
	public async Task<IActionResult> GetAll([FromServices] IGetAllFuncionariosUseCase useCase)
	{
		List<ResponseShortFuncionarioJson> funcionarios = await useCase.ExecuteAsync();

		if (funcionarios.Count > 0)
			return Ok(funcionarios);
		return NoContent();
	}

	[HttpGet]
	[Route("{name}")]
	[ProducesResponseType(typeof(ResponseWorkerJson), StatusCodes.Status200OK)]
	[ProducesResponseType(StatusCodes.Status404NotFound)]
	[ProducesResponseType(StatusCodes.Status400BadRequest)]
	public async Task<IActionResult> GetByName([FromServices] IGetByNameUseCase useCase, [FromRoute] string name)
	{
		var response = await useCase.ExecuteAsync(name);
		
		return Ok(response);
	}

	[HttpPut]
	[Route("{id}")]
	[ProducesResponseType(StatusCodes.Status204NoContent)]
	[ProducesResponseType(StatusCodes.Status404NotFound)]
	[ProducesResponseType(StatusCodes.Status400BadRequest)]
	public async Task<IActionResult> Update([FromServices]IUpdateFuncionariosUseCase useCase, [FromBody]RequestUpdateFuncionarioJson request,[FromRoute] string id)
	{
		await useCase.ExecuteAsync(request, id);
		
		return NoContent();
	}

	[HttpDelete]
	[Route("{id}")]
	[ProducesResponseType(StatusCodes.Status204NoContent)]
	[ProducesResponseType(StatusCodes.Status404NotFound)]
	[ProducesResponseType(StatusCodes.Status400BadRequest)]
	public async Task<IActionResult> Delete([FromServices] IDeleteFuncionarioUseCase useCase, [FromRoute] string id)
	{
		await useCase.ExecuteAsync(id);
			
		return NoContent();
	}
}
