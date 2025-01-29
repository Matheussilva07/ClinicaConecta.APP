using Clinica.Desktop.Communication.Funcionarios.Enums;
using Clinica.Desktop.HTTP_Funcionarios;

namespace Clinica.Desktop.Formularios;
public partial class FormularioFuncionarios : Form
{
	public FormularioFuncionarios()
	{
		InitializeComponent();
	}

	private void Btn_Cadastrar_Funcionarios_Click(object sender, EventArgs e)
	{
		var form = new FormularioCadastrarFuncionarios();
		form.ShowDialog();
	}

	private async void FormularioFuncionarios_Load(object sender, EventArgs e)
	{
		var funcionarios = await HttpClient_workers.DoGetAll();

		if (funcionarios.Count <= 0)
		{
			return;
		}

		dataGridView_Funcionarios.DataSource = funcionarios;

		dataGridView_Funcionarios.Columns["Id"].Visible = false;
	}

	private void DataGridView_Funcionarios_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
	{
		if (e.RowIndex >= 0)
		{
			string id = dataGridView_Funcionarios.Rows[e.RowIndex].Cells["Id"].Value.ToString()!;
			string name = dataGridView_Funcionarios.Rows[e.RowIndex].Cells["Name"].Value.ToString()!;
			string? email = dataGridView_Funcionarios.Rows[e.RowIndex].Cells["Email"].Value.ToString()!;
			string cpf = dataGridView_Funcionarios.Rows[e.RowIndex].Cells["Cpf"].Value.ToString()!;
			string rg = dataGridView_Funcionarios.Rows[e.RowIndex].Cells["Rg"].Value.ToString()!;
			string address = dataGridView_Funcionarios.Rows[e.RowIndex].Cells["Address"].Value.ToString()!;
			string telephone = dataGridView_Funcionarios.Rows[e.RowIndex].Cells["Telephone"].Value.ToString()!;
			string function = dataGridView_Funcionarios.Rows[e.RowIndex].Cells["Function"].Value.ToString()!;
			DateTime date_hire = (DateTime)dataGridView_Funcionarios.Rows[e.RowIndex].Cells["Date_Hire"].Value;
			DateTime date_fire = (DateTime)dataGridView_Funcionarios.Rows[e.RowIndex].Cells["Date_Fire"].Value;
			ContractType contractType = (ContractType)dataGridView_Funcionarios.Rows[e.RowIndex].Cells["Contract_Type"].Value;
			int workHours = (int)dataGridView_Funcionarios.Rows[e.RowIndex].Cells["Work_hours"].Value;
			string bankAccount = dataGridView_Funcionarios.Rows[e.RowIndex].Cells["BankAccount"].Value.ToString()!;
			
			var form = new FormularioCadastrarFuncionarios(id, name, email,cpf,rg,address,telephone,function,date_hire,date_fire,contractType,workHours,bankAccount );

			form.ShowDialog();
		}
	}
}
