namespace clinica.Communication.Consultas.Responses;
public class ResponseRegisteredConsultaJson
{
	public string Nome_Paciente { get; set; } = string.Empty;
	public string Nome_Profissional { get; set; } = string.Empty;
	public DateTime Data_Consulta { get; set; }
	public string Horarios { get; set; } = string.Empty;
}
