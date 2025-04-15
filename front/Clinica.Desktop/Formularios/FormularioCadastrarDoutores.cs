using Clinica.Desktop.Communication.Doctors.Enums;
using Clinica.Desktop.Communication.Doctors.Requests;
using Clinica.Desktop.Communication.Doctors.Responses;
using Clinica.Desktop.HTTP_Doctors;

namespace Clinica.Desktop.Formularios;
public partial class FormularioCadastrarDoutores : Form
{
	private readonly string? _id;
	private readonly string? _name;
	private readonly string? _email;
	private readonly string? _cpf;
	private readonly string? _rg;
	private readonly string? _address;
	private readonly string? _telephone;
	private readonly string? _expertise;
	private readonly DateTime _date_hire;
	private readonly DateTime _date_fire;
	private readonly decimal? _value;
	private readonly Expiration? _expiration;
	private readonly int? _sessions;
	private readonly int? _work_hours;
	private readonly string? _turns;
	private readonly string? _bankAccount;

	public ResponseDoctor? Doctor { get; set; }

	public FormularioCadastrarDoutores()
	{
		InitializeComponent();
	}
	public FormularioCadastrarDoutores(bool isButtonVisible)
	{
		InitializeComponent();
		Btn_Atualizar.Visible = isButtonVisible;
		Btn_Cadastrar.Visible = isButtonVisible;
		Btn_Delete.Visible = isButtonVisible;
		this.Width = 559;
		this.Height = 467;
		Btn_Pesquisar.Location = new Point(8, 366);
	}
	public FormularioCadastrarDoutores(string id, string name, string email, string phone, string cpf, string rg, string address,
									   string expertise, DateTime dateHire, DateTime dateFire, decimal value, Expiration expiration,
									   int sessions, int workHours, string turns, string bankAccount)
	{
		InitializeComponent();
		_id = id;
		_name = name;
		_email = email;
		_address = address;
		_cpf = cpf;
		_rg = rg;
		_telephone = phone;
		_expertise = expertise;
		_date_hire = dateHire;
		_date_fire = dateFire;
		_value = value;
		_expiration = expiration;
		_sessions = sessions;
		_work_hours = workHours;
		_turns = turns;
		_bankAccount = bankAccount;
	}
	private void FormularioCadastrarDoutores_Load(object sender, EventArgs e)
	{
		if (_name is not null)
		{
			Lbl_ID.Text = _id;
			Txt_Name.Text = _name;
			Txt_Email.Text = _email;
			Txt_Address.Text = _address;
			Txt_CPF.Text = _cpf;
			Txt_RG.Text = _rg;
			Txt_Telephone.Text = _telephone;
			Txt_Especialidade.Text = _expertise;
			Txt_Date_Hire.Value = _date_hire;
			Txt_Date_Fire.Value = _date_fire;
			Txt_Valor.Text = _value.ToString();
			comboBox_Vencimento.Text = _expiration.ToString();
			Txt_Sessoes.Text = _sessions.ToString();
			Txt_WorkHours.Text = _work_hours.ToString();
			Txt_Turnos.Text = _turns.ToString();
			Txt_Account.Text = _bankAccount.ToString();
		}
	}

	private async void Btn_Cadastrar_Click(object sender, EventArgs e)
	{
		Expiration vencimento = comboBox_Vencimento.Text switch
		{
			"Vigente" => Expiration.Vigente,
			"Vencido" => Expiration.Vencido,
			_ => throw new NotImplementedException(),
		};

		var request = new RequestRegisterDoctorJson
		{
			Name = Txt_Name.Text,
			Email = Txt_Email.Text,
			Cpf = Txt_CPF.Text,
			Rg = Txt_RG.Text,
			Address = Txt_Address.Text,
			Telephone = Txt_Telephone.Text,
			Expertise = Txt_Especialidade.Text,
			Date_Hire = Txt_Date_Hire.Value,
			Date_Fire = Txt_Date_Fire.Value,
			Value = Convert.ToDecimal(Txt_Valor.Text),
			Expiration = vencimento,
			Sessions = Convert.ToInt32(Txt_Sessoes.Text),
			Work_hours = Convert.ToInt32(Txt_WorkHours.Text),
			Turns = Txt_Turnos.Text,
			BankAccount = Txt_Account.Text,
		};

		bool isSuccessful = await HttpClient_Doctors.DoPost(request);

		if (isSuccessful)
		{
			MessageBox.Show("Cadastrado com sucesso");
		}
		else
		{
			MessageBox.Show("Erro ao cadastrar");
		}
	}

	private async void Btn_Pesquisar_Click(object sender, EventArgs e)
	{
		string name = Txt_Name.Text;

		Doctor = await HttpClient_Doctors.DoGetByName(name);

		if (Doctor is null)
		{
			MessageBox.Show("Cadastro não encontrado");
		}

		Lbl_ID.Text = Doctor.Id;
		Txt_Name.Text = Doctor.Name;
		Txt_Email.Text = Doctor.Email;
		Txt_CPF.Text = Doctor.Cpf;
		Txt_RG.Text = Doctor.Rg;
		Txt_Address.Text = Doctor.Address;
		Txt_Telephone.Text = Doctor.Telephone;
		Txt_Especialidade.Text = Doctor.Expertise;
		Txt_Date_Hire.Text = Doctor.Date_Hire.ToString();
		Txt_Date_Fire.Text = Doctor.Date_Fire.ToString();
		Txt_Valor.Text = Doctor.Value.ToString();
		comboBox_Vencimento.Text = Doctor.Expiration.ToString();
		Txt_Sessoes.Text = Doctor.Sessions.ToString();
		Txt_WorkHours.Text = Doctor.Work_hours.ToString();
		Txt_Turnos.Text = Doctor.Turns.ToString();
		Txt_Account.Text = Doctor.BankAccount;

	}

	private async void Btn_Atualizar_Click(object sender, EventArgs e)
	{
		Expiration vencimento = comboBox_Vencimento.Text switch
		{
			"Vigente" => Expiration.Vigente,
			"Vencido" => Expiration.Vencido,
			_ => throw new NotImplementedException(),
		};

		var request = new RequestUpdateDoctorJson()
		{
			Name = Txt_Name.Text,
			Email = Txt_Email.Text,
			Cpf = Txt_CPF.Text,
			Rg = Txt_RG.Text,
			Address = Txt_Address.Text,
			Telephone = Txt_Telephone.Text,
			Expertise = Txt_Especialidade.Text,
			Date_Hire = Txt_Date_Hire.Value,
			Date_Fire = Txt_Date_Fire.Value,
			Value = Convert.ToDecimal(Txt_Valor.Text),
			Expiration = vencimento,
			Sessions = Convert.ToInt32(Txt_Sessoes.Text),
			Work_hours = Convert.ToInt32(Txt_WorkHours.Text),
			Turns = Txt_Turnos.Text,
			BankAccount = Txt_Account.Text,

		};

		bool isSuccessfull = await HttpClient_Doctors.DoPut(request, Lbl_ID.Text);

		if (isSuccessfull)
		{
			MessageBox.Show("Cadastro atualizado com sucesso!");
		}
		else
		{
			MessageBox.Show("Erro ao atualizar!");
		}
	}

	private async void Btn_Delete_Click(object sender, EventArgs e)
	{
		bool isSuccessfull = await HttpClient_Doctors.DoDelete(_id!);

		if (isSuccessfull)
		{
			MessageBox.Show("Cadastro deletado com sucesso");
		}
		else
		{
			MessageBox.Show("Erro ao deletar o cadastro!");
		}
	}
}
