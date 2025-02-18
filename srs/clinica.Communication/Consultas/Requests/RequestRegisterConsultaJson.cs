using clinica.Communication.Consultas.Enums;

namespace clinica.Communication.Consultas.Requests;
public class RequestRegisterConsultaJson
{
	public string Nome_Paciente { get; set; } = string.Empty;
	public string Cpf_Paciente { get; set; } = string.Empty;
	public string Celular_Paciente { get; set; } = string.Empty;
	public string Servico { get; set; } = string.Empty;
	public string Nome_Profissional { get; set; } = string.Empty;
	public string Especialidade { get; set; } = string.Empty;
	public DateTime Data_Consulta { get; set; }
	public string Horarios { get; set; } = string.Empty;
	public FormasPagamento Forma_Pagamento { get; set; }
	public decimal Valor { get; set; }
	public double Desconto { get; set; }
}
