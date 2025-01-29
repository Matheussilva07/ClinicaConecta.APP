namespace clinica.Communication.Pacientes.Requests;
public class RequestRegisterPacienteJson
{
	public string Name { get; set; } = string.Empty;
	public string? Email { get; set; } = string.Empty;
	public string Telephone { get; set; } = string.Empty;
	public string CPF { get; set; } = string.Empty;
	public string Address { get; set; } = string.Empty;
	public DateTime Birth { get; set; }
}
