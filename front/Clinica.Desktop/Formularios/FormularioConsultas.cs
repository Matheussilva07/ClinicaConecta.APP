using Clinica.Desktop.Communication.Consultas.Enums;
using Clinica.Desktop.Communication.Consultas.Requests;
using Clinica.Desktop.HTTP_Consultas;

namespace Clinica.Desktop.Formularios;
public partial class FormularioConsultas : Form
{
	double desconto = 0;
	private string _name;
	private string _cpf;
	private string _phone;
	public FormularioConsultas()
	{
		InitializeComponent();
	}
	public FormularioConsultas(string name, string cpf, string phone)
	{
		InitializeComponent();

	}

	private async void Btn_Salvar_Agendamento_Click(object sender, EventArgs e)
	{
		bool isEmpty = AlertarCamposVazios();

		if (isEmpty)
		{
			return;
		}

		if (string.IsNullOrWhiteSpace(txt_Desconto.Text))
		{
			desconto = 0;
		}

		FormasPagamento formaPagamento = comboBox_Formas_Pagamento.Text switch
		{
			"DINHEIRO" => FormasPagamento.DINHEIRO,
			"PIX" => FormasPagamento.PIX,
			"CRÉDITO" => FormasPagamento.CRÉDITO,
			"DÉBITO" => FormasPagamento.DÉBITO,

			_ => FormasPagamento.DINHEIRO
		};

		var request = new RequestRegisterConsultaJson
		{
			Nome_Paciente = txt_Nome.Text,
			Cpf_Paciente = txt_CPF.Text,
			Celular_Paciente = txt_Celular.Text,
			Servico = txt_Servico.Text,
			Nome_Profissional = txt_Nome_Profissional.Text,
			Especialidade = txt_Especialidade.Text,
			Data_Consulta = monthCalendar_Data_Consultas.SelectionStart,
			Horarios = comboBox_Horarios_Consultas.Text,
			Forma_Pagamento = formaPagamento,
			Valor = Convert.ToDecimal(txt_Valor.Text),
			Desconto = desconto
		};

		bool isSuccessfull = await HttpClient_Consultas.DoPost(request);

		if (isSuccessfull)
		{
			MessageBox.Show("Consulta agendada com sucesso!");
		}
		else
		{
			MessageBox.Show("Erro ao marcar a consulta!");
		}
	}

	private bool AlertarCamposVazios()
	{
		List<string> errorMessages = new();

		if (string.IsNullOrWhiteSpace(txt_Nome.Text))
		{
			errorMessages.Add("Preencha o nome do paciente");
		}
		if (txt_CPF.MaskCompleted == false)
		{
			errorMessages.Add("Preencha o CPF do paciente");
		}
		if (txt_Celular.MaskCompleted == false)
		{
			errorMessages.Add("Preencha o telefone do paciente");
		}
		if (string.IsNullOrWhiteSpace(txt_Servico.Text))
		{
			errorMessages.Add("Preencha o tipo de serciço");
		}
		if (string.IsNullOrWhiteSpace(txt_Nome_Profissional.Text))
		{
			errorMessages.Add("Preencha o nome do profissional");
		}
		if (string.IsNullOrWhiteSpace(txt_Especialidade.Text))
		{
			errorMessages.Add("Preencha a especialidade");
		}
		if (monthCalendar_Data_Consultas.SelectionStart < DateTime.Today)
		{
			errorMessages.Add("Preencha o dia da consulta");
		}
		if (string.IsNullOrWhiteSpace(comboBox_Horarios_Consultas.Text))
		{
			errorMessages.Add("Preencha o horário da consulta");
		}
		if (string.IsNullOrWhiteSpace(txt_Valor.Text))
		{
			errorMessages.Add("Preencha o valor da consulta");
		}

		if (errorMessages.Count > 0)
		{
			string messagem = string.Join(Environment.NewLine, errorMessages);
			MessageBox.Show(messagem);
			return true;

		}
		else
		{
			return false;
		}

	}

	private void Btn_Pesquisar_Pacientes_Click(object sender, EventArgs e)
	{
		var form = new FormularioCadastrarPacientes(false);
		form.ShowDialog();

	}
}
