using Clinica.Desktop.Communication.Pacientes.Requests;
using Clinica.Desktop.Communication.Pacientes.Responses;
using Clinica.Desktop.HTTP_Pacientes;

namespace Clinica.Desktop.Formularios;
public partial class FormularioCadastrarPacientes : Form
{
	private string? _id;
	private readonly string? _name;
	private readonly string? _email;
	private readonly string? _phone;
	private readonly string? _cpf;
	private readonly string? _address;
	private readonly DateTime _birth;
	public ResponseRegisteredPaciente? Paciente { get; set; }

	public FormularioCadastrarPacientes(bool isButttonVisible)
	{
		InitializeComponent();
		Btn_Cadastrar_Pacientes.Visible = isButttonVisible;
		Btn_Atualizar_Pacientes.Visible = isButttonVisible;
		Btn_Delete_Pacientes.Visible = isButttonVisible;

		Btn_Pesquisar_Pacientes.Location = new Point(14, 296);
	}
	public FormularioCadastrarPacientes()
	{
		InitializeComponent();
	}
	public FormularioCadastrarPacientes(string id, string name, string email, string phone, string cpf, string address, DateTime birth)
	{
		InitializeComponent();

		Btn_Cadastrar_Pacientes.Enabled = false;
		Btn_Cadastrar_Pacientes.Visible = false;

		Btn_Pesquisar_Pacientes.Enabled = false;
		Btn_Pesquisar_Pacientes.Visible = false;

		_id = id;
		_name = name;
		_email = email;
		_phone = phone;
		_cpf = cpf;
		_address = address;
		_birth = birth;
	}
	private async void Btn_Cadastrar_Paciente_Click(object sender, EventArgs e)
	{
		var request = new RegisterPaciente
		{
			Name = Txt_Name.Text,
			Email = Txt_Email.Text,
			Address = Txt_Address.Text,
			Birth = Txt_Birth.Value,
			CPF = Txt_CPF.Text,
			Telephone = Txt_Telephone.Text,
		};

		bool result = await HttpClient_Pacientes.DoPost(request);

		if (result)
		{
			MessageBox.Show("Paciente cadastrado com sucesso!");
		}
		else
		{
			MessageBox.Show("Erro ao cadastrar o paciente!");
		}
	}
	private void FormularioCadastrarPacientes_Load(object sender, EventArgs e)
	{
		if (_name is not null)
		{
			Lbl_ID.Text = _id;
			Txt_Name.Text = _name;
			Txt_Email.Text = _email;
			Txt_Telephone.Text = _phone;
			Txt_CPF.Text = _cpf;
			Txt_Address.Text = _address;
			Txt_Birth.Value = _birth;
		}
	}
	private async void Btn_Atualizar_Paciente_Click(object sender, EventArgs e)
	{
		bool isSuccessfull = await HttpClient_Pacientes.DoUpdate(id: _id, name: Txt_Name.Text, email: Txt_Email.Text, phone: Txt_Telephone.Text, cpf: Txt_CPF.Text, address: Txt_Address.Text, birth: Convert.ToDateTime(Txt_Birth.Text));

		if (isSuccessfull)
		{
			MessageBox.Show("Cadastro atualizado com sucesso!");
		}
		else
		{
			MessageBox.Show("Erro ao atualizar o cadastro!");
		}
	}
	private async void Btn_Deletar_Pacientes_Click(object sender, EventArgs e)
	{
		bool isDeleted = await HttpClient_Pacientes.DoDelete(_id);

		if (isDeleted)
		{
			MessageBox.Show("Deletado com sucesso!");
		}
		else
		{
			MessageBox.Show("Erro ao deletar o cadastro!");
		}
	}
	private async void Btn_Pesquisar_Pacientes_Click(object sender, EventArgs e)
	{
		string name = Txt_Name.Text;

		Paciente = await HttpClient_Pacientes.DoGetByName(name);

		if (Paciente is not null)
		{
			_id = Paciente.Id;
			Txt_Name.Text = Paciente.Name;
			Txt_Email.Text = Paciente.Email;
			Txt_Telephone.Text = Paciente.Telephone;
			Txt_CPF.Text = Paciente.CPF;
			Txt_Address.Text = Paciente.Address;
			Txt_Birth.Value = Paciente.Birth;						
		}
		else{
			MessageBox.Show("Paciente não encontrado.");
		}
	}
}


