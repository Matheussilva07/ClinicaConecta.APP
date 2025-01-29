namespace Clinica.Desktop.Communication.Pacientes.Responses;
public class ResponseRegisteredPaciente
{
    public string Id { get; set; } = string.Empty;
    public string Name { get; set; } = string.Empty;
    public string? Email { get; set; } = string.Empty;
    public string Telephone { get; set; } = string.Empty;
    public string CPF { get; set; } = string.Empty;
    public string Address { get; set; } = string.Empty;
    public DateTime Birth { get; set; }
}
