using clinica.Communication.Funcionarios.Requests;
using clinica.Communication.FuncionariosGerais.Requests;
using FluentValidation;

namespace clinica.Application.FuncionariosUseCases;
public class RegisterFuncionariosValidator : AbstractValidator<RequestRegisterFuncionarioJson>
{
	public RegisterFuncionariosValidator()
	{
		RuleFor(f => f.Name).NotEmpty().WithMessage("Informe o nome do funcionário");
		RuleFor(f => f.Email).NotEmpty().WithMessage("Informe o email do funcionário").When(f => string.IsNullOrWhiteSpace(f.Email) == false , ApplyConditionTo.CurrentValidator).EmailAddress().WithMessage("Email inválido");
		RuleFor(f => f.Cpf).NotEmpty().WithMessage("Informe o cpf do funcionário");
		RuleFor(f => f.Rg).NotEmpty().WithMessage("Informe o rg do funcionário");
		RuleFor(f => f.Address).NotEmpty().WithMessage("Informe o endereço do funcionário");
		RuleFor(f => f.Telephone).NotEmpty().WithMessage("Informe o telefone do funcionário");
		RuleFor(f => f.Function).NotEmpty().WithMessage("Informe a função do funcionário");
		RuleFor(f => f.Date_Hire).NotEmpty().WithMessage("Informe a data de contrato do funcionário");
		RuleFor(f => f.Contract_Type).IsInEnum().WithMessage("Informe o tipo de contrato do funcionário");
		RuleFor(f => f.Work_hours).GreaterThan(0).WithMessage("Informe as horas de trabalho do funcionário");
		RuleFor(f => f.BankAccount).NotEmpty().WithMessage("Informe a conta bancária do funcionário");
	}
}
public class UpdateFuncionariosValidator : AbstractValidator<RequestUpdateFuncionarioJson>
{
	public UpdateFuncionariosValidator()
	{
		RuleFor(f => f.Name).NotEmpty().WithMessage("Informe o nome do funcionário");
		RuleFor(f => f.Email).NotEmpty().WithMessage("Informe o email do funcionário").When(f => string.IsNullOrWhiteSpace(f.Email) == false, ApplyConditionTo.CurrentValidator).EmailAddress().WithMessage("Email inválido");
		RuleFor(f => f.Cpf).NotEmpty().WithMessage("Informe o cpf do funcionário");
		RuleFor(f => f.Rg).NotEmpty().WithMessage("Informe o rg do funcionário");
		RuleFor(f => f.Address).NotEmpty().WithMessage("Informe o endereço do funcionário");
		RuleFor(f => f.Telephone).NotEmpty().WithMessage("Informe o telefone do funcionário");
		RuleFor(f => f.Function).NotEmpty().WithMessage("Informe a função do funcionário");
		RuleFor(f => f.Date_Hire).NotEmpty().WithMessage("Informe a data de contrato do funcionário");
		RuleFor(f => f.Contract_Type).IsInEnum().WithMessage("Informe o tipo de contrato do funcionário");
		RuleFor(f => f.Work_hours).GreaterThan(0).WithMessage("Informe as horas de trabalho do funcionário");
		RuleFor(f => f.BankAccount).NotEmpty().WithMessage("Informe a conta bancária do funcionário");
	}
}
