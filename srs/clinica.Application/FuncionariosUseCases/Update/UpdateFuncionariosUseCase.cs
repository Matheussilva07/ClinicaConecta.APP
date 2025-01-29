using AutoMapper;
using clinica.Communication.Funcionarios.Requests;
using clinica.Domain.Entities;
using clinica.Domain.Repositories.Funcionarios;

namespace clinica.Application.FuncionariosUseCases.Update;
internal class UpdateFuncionariosUseCase : IUpdateFuncionariosUseCase
{
	private readonly IMapper _mapper;
	private readonly IUpdateOnlyWorkersRepository _repository;

	public UpdateFuncionariosUseCase(IMapper mapper, IUpdateOnlyWorkersRepository repository)
	{
		_mapper = mapper;
		_repository = repository;
	}
	public async Task ExecuteAsync(RequestUpdateFuncionarioJson request, string id)
	{
		Validate(request);

		var funcionario = _mapper.Map<Funcionario>(request);

		await _repository.UpdateAsync(funcionario, id);
	}
	private static void Validate(RequestUpdateFuncionarioJson request)
	{
		var validator = new UpdateFuncionariosValidator();

		var result = validator.Validate(request);

		if (result.IsValid == false)
		{
			throw new ArgumentException("Dados inválidos");
		}
	}
}
