using AutoMapper;
using clinica.Communication.Funcionarios.Responses;
using clinica.Domain.Repositories.FuncionariosGerais;

namespace clinica.Application.FuncionariosUseCases.GetAll;
internal class GetAllFuncionariosUseCase : IGetAllFuncionariosUseCase
{
	private readonly IMapper _mapper;
	private readonly IReadOnlyWorkersRepository _repository;

	public GetAllFuncionariosUseCase(IMapper mapper, IReadOnlyWorkersRepository repository)
	{
		_mapper = mapper;
		_repository = repository;
	}

	public async Task<List<ResponseShortFuncionarioJson>> ExecuteAsync()
	{
		var pacientes = await _repository.GetAllAsync();

		return _mapper.Map<List<ResponseShortFuncionarioJson>>(pacientes);
	}
}
