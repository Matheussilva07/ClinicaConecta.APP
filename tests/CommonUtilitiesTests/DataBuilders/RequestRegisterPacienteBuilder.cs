using Bogus;
using clinica.Communication.Pacientes.Requests;

namespace CommonUtilitiesTests.DataBuilders;
public class RequestRegisterPacienteBuilder
{
	public static RequestRegisterPacienteJson Build()
	{
		return new Faker<RequestRegisterPacienteJson>()
			.RuleFor(p => p.Name, f => f.Person.FullName)
			.RuleFor(p => p.Telephone, f => f.Person.Phone)
			.RuleFor(p => p.Address, f => f.Person.Address.ToString())
			.RuleFor(p => p.Birth, f => f.Person.DateOfBirth);
	}
}
