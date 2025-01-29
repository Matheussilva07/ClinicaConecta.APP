using Clinica.Desktop.Communication.Funcionarios.Enums;
using Clinica.Desktop.Communication.Funcionarios.Requests;
using Clinica.Desktop.HTTP_Funcionarios;

namespace Clinica.Desktop.Formularios;
public partial class FormularioCadastrarFuncionarios : Form
{
	private readonly string _id;
	private readonly string _name;
	private readonly string _email;
	private readonly string _cpf;
	private readonly string _rg;
	private readonly string _address;
	private readonly string _telephone;
	private readonly string _function;
	private readonly DateTime _date_hire;
	private readonly DateTime _date_fire;
	private readonly ContractType _contractType;
	private readonly int _workHours;
	private readonly string _bankAccount;
	public FormularioCadastrarFuncionarios()
	{
		InitializeComponent();
	}
	public FormularioCadastrarFuncionarios(string id, string name, string email, string cpf, string rg, string address, string telephone, string function,
		DateTime date_hire, DateTime date_fire, ContractType contractType, int workHours, string bankAccount)
	{
		InitializeComponent();

		_id = id;
		_name = name;
		_email = email;
		_cpf = cpf;
		_rg = rg;
		_address = address;
		_telephone = telephone;
		_function = function;
		_date_hire = date_hire;
		_date_fire = date_fire;
		_contractType = contractType;
		_workHours = workHours;
		_bankAccount = bankAccount;
	}
	private async void FormularioCadastrarFuncionarios_Load(object sender, EventArgs e)
	{
		await FillTheFields(_id);
	}

	private async void Btn_Cadastrar_Click(object sender, EventArgs e)
	{
		byte contractType = ComboBox_ContractType.Text switch
		{
			"CLT" => 1,
			"PJ" => 2,
			"Estágio" => 3,
			"Diária" => 4,
			_ => 0
		};

		var request = new RequestRegisterFuncionarioJson
		{
			Name = Txt_Name.Text,
			Email = Txt_Email.Text,
			Cpf = Txt_CPF.Text,
			Rg = Txt_RG.Text,
			Address = Txt_Address.Text,
			Telephone = Txt_Telephone.Text,
			Function = Txt_Function.Text,
			Date_Hire = Txt_Date_Hire.Value,
			Date_Fire = Txt_Date_Fire.Value,
			Contract_Type = contractType,
			Work_hours = Convert.ToByte(Txt_WorkHours.Text),
			BankAccount = Txt_Account.Text
		};

		bool isSuccessful = await HttpClient_workers.DoPost(request);

		if (isSuccessful)
		{
			MessageBox.Show("Funcionário cadastrado com sucesso!");
		}
		else
		{
			MessageBox.Show("Erro ao cadastrar!");
		}
	}

	private async void Btn_Pesquisar_Click(object sender, EventArgs e)
	{
		string name = Txt_Name.Text;
		
		var worker = await HttpClient_workers.DoGetByName(name);

		if(worker is not null)
		{
			Lbl_ID.Text = worker.Id;
			Txt_Name.Text = worker.Name;
			Txt_Email.Text = worker.Email;
			Txt_CPF.Text = worker.Cpf;
			Txt_RG.Text = worker.Rg;
			Txt_Address.Text = worker.Address;
			Txt_Telephone.Text = worker.Telephone;
			Txt_Function.Text = worker.Function;
			Txt_Date_Hire.Text = worker.Date_Hire.ToString();
			Txt_Date_Fire.Text = worker.Date_Fire.ToString();
			ComboBox_ContractType.Text = worker.Contract_Type.ToString();
			Txt_WorkHours.Text = worker.Work_hours.ToString();
			Txt_Account.Text = worker.BankAccount;
		}
	}

	private async void Btn_Atualizar_Click(object sender, EventArgs e)
	{
		byte contractType = ComboBox_ContractType.Text switch
		{
			"CLT" => 1,
			"PJ" => 2,
			"Estágio" => 3,
			"Diária" => 4,
			_ => 0
		};


		var request = new RequestUpdateFuncionarioJson
		{
			Name = Txt_Name.Text,
			Email = Txt_Email.Text,
			Cpf = Txt_CPF.Text,
			Rg = Txt_RG.Text,
			Address = Txt_Address.Text,
			Telephone = Txt_Telephone.Text,
			Function = Txt_Function.Text,
			Date_Hire = Txt_Date_Hire.Value,
			Date_Fire = Txt_Date_Fire.Value,
			Contract_Type = contractType,
			Work_hours = Convert.ToByte(Txt_WorkHours.Text),
			BankAccount = Txt_Account.Text
		};

		bool isSuccessfull = await HttpClient_workers.DoUpdate(_id, request);

		if (isSuccessfull)
		{
			MessageBox.Show("Cadastro atualizado com sucesso!");
		}
		else
		{
			MessageBox.Show("Erro ao atualizar");
		}
	}

	private async void Btn_Delete_Click(object sender, EventArgs e)
	{
		bool isSuccessful = await HttpClient_workers.DoDelete(_id);

		if (isSuccessful)
		{
			MessageBox.Show("Cadastro deletado com sucesso!");
		}
		else
		{
			MessageBox.Show("Erro ao deletar o cadastro!");
		}
	}

	private async Task FillTheFields(string id)
	{
		if (id is not null)
		{
			Lbl_ID.Text = _id.ToString();
			Txt_Name.Text = _name;
			Txt_Email.Text = _email;
			Txt_CPF.Text = _cpf;
			Txt_RG.Text = _rg;
			Txt_Address.Text = _address;
			Txt_Telephone.Text = _telephone;
			Txt_Function.Text = _function;
			Txt_Date_Hire.Value = _date_hire;
			Txt_Date_Fire.Value = _date_fire;
			ComboBox_ContractType.Text = _contractType.ToString();
			Txt_WorkHours.Text = _workHours.ToString();
			Txt_Account.Text = _bankAccount;
		}
	}

	
}
