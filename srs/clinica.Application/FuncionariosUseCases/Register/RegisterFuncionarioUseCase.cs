using AutoMapper;
using clinica.Communication.FuncionariosGerais.Requests;
using clinica.Communication.FuncionariosGerais.Responses;
using clinica.Domain.Entities;
using clinica.Domain.Repositories.FuncionariosGerais;
using Microsoft.Extensions.Options;

namespace clinica.Application.FuncionariosUseCases.Register;
internal class RegisterFuncionarioUseCase : IRegisterFuncionarioUseCase
{
    private readonly IMapper _mapper;
    private readonly IWriteOnlyWorkersRepository _repository;

    public RegisterFuncionarioUseCase(IWriteOnlyWorkersRepository repository, IMapper mapper)
    {
        _mapper = mapper;
        _repository = repository;
    }

    public async Task<ResponseRegisteredFuncionarioJson> ExecuteAsync(RequestRegisterFuncionarioJson request)
    {
        Validate(request);

        var funcionario = _mapper.Map<Funcionario>(request);

        await _repository.AddAsync(funcionario);

        return _mapper.Map<ResponseRegisteredFuncionarioJson>(funcionario);
    }
    private static void Validate(RequestRegisterFuncionarioJson request)
    {
        var result = new RegisterFuncionariosValidator().Validate(request);

        if (result.IsValid == false)
        {
            throw new ArgumentException("Dados inválidos!");
        }
    }
}
