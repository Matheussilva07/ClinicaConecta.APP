using clinica.Communication.Consultas.Requests;
using FluentValidation;

namespace clinica.Application.ConsultasUseCases;
public class ConsultasValidator : AbstractValidator<RequestRegisterConsultaJson>
{
    public ConsultasValidator()
    {
        RuleFor(c => c.Nome_Paciente).NotEmpty().WithMessage("Informe o nome do paciente");
        RuleFor(c => c.Cpf_Paciente).NotEmpty().WithMessage("Informe o cpf do paciente");
        RuleFor(c => c.Celular_Paciente).NotEmpty().WithMessage("Informe o telefone do paciente");
        RuleFor(c => c.Servico).NotEmpty().WithMessage("Informe o tipo de serviço");
        RuleFor(c => c.Nome_Profissional).NotEmpty().WithMessage("Informe o nome do profissional");
        RuleFor(c => c.Especialidade).NotEmpty().WithMessage("Informe a especialidade do profissional");
        RuleFor(c => c.Data_Consulta).GreaterThan(DateTime.UtcNow).WithMessage("Informe o nome do paciente");
        RuleFor(c => c.Horarios).NotEmpty().WithMessage("Informe o nome do paciente");
        RuleFor(c => c.Forma_Pagamento).IsInEnum().WithMessage("Forma de pagamento inválida!");
        RuleFor(c => c.Valor).GreaterThan(0).WithMessage("O valor da consulta deve ser maior que zero");
    
    }
}
