using AutoMapper;
using clinica.Communication.Funcionarios.Responses;
using clinica.Domain.Repositories.FuncionariosGerais;

namespace clinica.Application.FuncionariosUseCases.GetByName;
internal class GetByNameUseCase : IGetByNameUseCase
{
	private readonly IMapper _mapper;
	private readonly IReadOnlyWorkersRepository _repository;

	public GetByNameUseCase(IMapper mapper, IReadOnlyWorkersRepository repository)
	{
		_mapper = mapper;
		_repository = repository;
	}

	public async Task<ResponseWorkerJson> ExecuteAsync(string name)
	{
		var worker = await _repository.GetByName(name) ?? throw new ArgumentException("Funcionário não encontrado!");

		return _mapper.Map<ResponseWorkerJson>(worker);
	}
}
