using clinica.Application.UsersUseCases.Register;
using clinica.Communication.Users.Requests;
using FluentValidation;

namespace clinica.Application.UsersUseCases;
internal class UsersValidator : AbstractValidator<RequestRegisterUserJson>
{
    public UsersValidator()
    {
        RuleFor(user => user.Name).NotEmpty().WithMessage("O nome deve ser informado");
        RuleFor(user => user.Email).NotEmpty().WithMessage("Digite seu email")
       .When(user => string.IsNullOrWhiteSpace(user.Email) == false).EmailAddress().WithMessage("Email inválido");
        RuleFor(user => user.Password).SetValidator( new PasswordValidator<RequestRegisterUserJson>());
    }
}
