using FluentValidation;
using FluentValidation.Validators;
using System.Text.RegularExpressions;

namespace clinica.Application.UsersUseCases.Register;
internal class PasswordValidator<T> : PropertyValidator<T, string>
{
	private const string ERROR_MESSAGE_KEY = "ErrorMessage";
	public override string Name => "PasswordValidator";

	protected override string GetDefaultMessageTemplate(string errorCode)
	{
		return $"{{{ERROR_MESSAGE_KEY}}}";
	}
	public override bool IsValid(ValidationContext<T> context, string password)
	{
		if(string.IsNullOrWhiteSpace(password))
		{
			context.MessageFormatter.AppendArgument(ERROR_MESSAGE_KEY, "Digite a senha");
			return false;
		}
		if(password.Length < 8)
		{
			context.MessageFormatter.AppendArgument(ERROR_MESSAGE_KEY, "A senha deve conter pelo menos 8 caracteres");
			return false;
		}
		if(Regex.IsMatch(password, @"(?=.*[a-z])") == false)
		{
			context.MessageFormatter.AppendArgument(ERROR_MESSAGE_KEY, "Digite pelo menos uma letra minúscula");
			return false;
		}
		if (Regex.IsMatch(password, @"(?=.*[A-Z])") == false)
		{
			context.MessageFormatter.AppendArgument(ERROR_MESSAGE_KEY, "Digite pelo menos uma letra maiúscula");
			return false;
		}
		if (Regex.IsMatch(password, @"(?=.*\d)") == false)
		{
			context.MessageFormatter.AppendArgument(ERROR_MESSAGE_KEY, "Digite pelo menos um número");
			return false;
		}
		if (Regex.IsMatch(password, @"(?=.*[@$!%*?&])") == false)
		{
			context.MessageFormatter.AppendArgument(ERROR_MESSAGE_KEY, "Digite pelo menos um caractere especial");
			return false;
		}

		return true;
	}
}
