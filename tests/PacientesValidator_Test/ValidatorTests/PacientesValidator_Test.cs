using clinica.Application.PacientesUseCases;
using CommonUtilitiesTests.DataBuilders;
using FluentAssertions;

namespace Pacientes_Tests.ValidatorTests;
public class PacientesValidator_Test
{
	[Fact]
	public void Success()
	{
		var request = RequestRegisterPacienteBuilder.Build();

		var validator = new PacientesValidator();

		var result = validator.Validate(request);

		result.IsValid.Should().BeTrue();
		result.Errors.Should().BeEmpty();
	}

	[Theory]
	[InlineData("")]
	[InlineData("  ")]
	[InlineData(null)]
	public void Error_Name_Empty(string name)
	{
		var request = RequestRegisterPacienteBuilder.Build();
		request.Name = name;

		var validator = new PacientesValidator();

		var result = validator.Validate(request);


		result.IsValid.Should().BeFalse();
		result.Errors.Should().NotBeEmpty().And.HaveCount(1);
	}

}
