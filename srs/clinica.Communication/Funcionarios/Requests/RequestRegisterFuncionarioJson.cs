using clinica.Communication.FuncionariosGerais.Enums;

namespace clinica.Communication.FuncionariosGerais.Requests;
public class RequestRegisterFuncionarioJson
{
	public string Name { get; set; } = string.Empty;
	public string Email { get; set; } = string.Empty;
	public string Cpf { get; set; } = string.Empty;
	public string Rg { get; set; } = string.Empty;
	public string Address { get; set; } = string.Empty;
	public string Telephone { get; set; } = string.Empty;
	public string Function { get; set; } = string.Empty;
	public DateTime Date_Hire { get; set; }
	public DateTime? Date_Fire { get; set; } = null;
	public ContractType Contract_Type { get; set; }
	public int Work_hours { get; set; }
	public string BankAccount { get; set; } = string.Empty;
}
