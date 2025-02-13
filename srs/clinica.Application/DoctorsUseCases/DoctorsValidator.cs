using clinica.Communication.Doctors.Requests;
using FluentValidation;

namespace clinica.Application.Doctors;
public class DoctorsValidator : AbstractValidator<RequestRegisterDoctorJson>
{
    public DoctorsValidator()
    {
		RuleFor(d => d.Name).NotEmpty().WithMessage("Informe o nome");
		RuleFor(d => d.Email).NotEmpty().WithMessage("Informe o email").When(f => string.IsNullOrWhiteSpace(f.Email) == false, ApplyConditionTo.CurrentValidator).EmailAddress().WithMessage("Email inválido");
		RuleFor(d => d.Cpf).NotEmpty().WithMessage("Informe o cpf");
		RuleFor(d => d.Rg).NotEmpty().WithMessage("Informe o rg");
		RuleFor(d => d.Address).NotEmpty().WithMessage("Informe o endereço");
		RuleFor(d => d.Telephone).NotEmpty().WithMessage("Informe o telefone");
		RuleFor(d => d.Expertise).NotEmpty().WithMessage("Informe a especialidade");
		RuleFor(d => d.Date_Hire).NotEmpty().WithMessage("Informe a data de início do contrato");
		RuleFor(d => d.Date_Fire).GreaterThan(DateTime.UtcNow).WithMessage("Informe a data de término");
		RuleFor(d => d.Value).NotEmpty().WithMessage("Informe o valor do turno");
		RuleFor(d => d.Expiration).IsInEnum().WithMessage("Tipo inválido");
		RuleFor(d => d.Sessions).GreaterThan(0).WithMessage("Informe a quantidade de sessões");
		RuleFor(d => d.Work_hours).GreaterThan(0).WithMessage("Informe as horas de trabalho");
		RuleFor(d => d.Turns).NotEmpty().WithMessage("Informe os turnos de trabalho");
		RuleFor(d => d.BankAccount).NotEmpty().WithMessage("Informe a conta bancária");
	}
}

public class DoctorsUpdateValidator : AbstractValidator<RequestUpdateDoctorJson>
{
	public DoctorsUpdateValidator()
	{
		RuleFor(d => d.Name).NotEmpty().WithMessage("Informe o nome");
		RuleFor(d => d.Email).NotEmpty().WithMessage("Informe o email").When(f => string.IsNullOrWhiteSpace(f.Email) == false, ApplyConditionTo.CurrentValidator).EmailAddress().WithMessage("Email inválido");
		RuleFor(d => d.Cpf).NotEmpty().WithMessage("Informe o cpf");
		RuleFor(d => d.Rg).NotEmpty().WithMessage("Informe o rg");
		RuleFor(d => d.Address).NotEmpty().WithMessage("Informe o endereço");
		RuleFor(d => d.Telephone).NotEmpty().WithMessage("Informe o telefone");
		RuleFor(d => d.Expertise).NotEmpty().WithMessage("Informe a especialidade");
		RuleFor(d => d.Date_Hire).NotEmpty().WithMessage("Informe a data de início do contrato");
		RuleFor(d => d.Date_Fire).GreaterThan(DateTime.UtcNow).WithMessage("Informe a data de término");
		RuleFor(d => d.Value).NotEmpty().WithMessage("Informe o valor do turno");
		RuleFor(d => d.Expiration).IsInEnum().WithMessage("Tipo inválido");
		RuleFor(d => d.Sessions).GreaterThan(0).WithMessage("Informe a quantidade de sessões");
		RuleFor(d => d.Work_hours).GreaterThan(0).WithMessage("Informe as horas de trabalho");
		RuleFor(d => d.Turns).NotEmpty().WithMessage("Informe os turnos de trabalho");
		RuleFor(d => d.BankAccount).NotEmpty().WithMessage("Informe a conta bancária");
	}
}
