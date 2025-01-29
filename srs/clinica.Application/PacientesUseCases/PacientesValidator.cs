using clinica.Communication.Pacientes.Requests;
using FluentValidation;

namespace clinica.Application.PacientesUseCases;
public class PacientesValidator: AbstractValidator<RequestRegisterPacienteJson>
{
    public PacientesValidator()
    {
        RuleFor(p => p.Name).NotEmpty().WithMessage("Informe o nome do paciente");
        RuleFor(p => p.Telephone).NotEmpty().WithMessage("Informe o telefone do paciente");
        RuleFor(p => p.Address).NotEmpty().WithMessage("Informe o endereço do paciente");
        RuleFor(p => p.Birth).NotEmpty().LessThan(DateTime.UtcNow).WithMessage("Informe a data de nascimento do paciente");
    }
}
public class UpdatePacientesValidator : AbstractValidator<RequestUpdatePacienteJson>
{
	public UpdatePacientesValidator()
	{
		RuleFor(p => p.Name).NotEmpty().WithMessage("Informe o nome do paciente");
		RuleFor(p => p.Telephone).NotEmpty().WithMessage("Informe o telefone do paciente");
		RuleFor(p => p.Address).NotEmpty().WithMessage("Informe o endereço do paciente");
		RuleFor(p => p.Birth).NotEmpty().LessThan(DateTime.UtcNow).WithMessage("Informe a data de nascimento do paciente");
	}
}
