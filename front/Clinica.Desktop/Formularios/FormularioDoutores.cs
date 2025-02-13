using Clinica.Desktop.Communication.Doctors.Enums;
using Clinica.Desktop.HTTP_Doctors;

namespace Clinica.Desktop.Formularios;
public partial class FormularioDoutores : Form
{
	public FormularioDoutores()
	{
		InitializeComponent();
	}

	private async void FormularioDoutores_Load(object sender, EventArgs e)
	{
		var doctors = await HttpClient_Doctors.DoGetAll();

		dataGridView_Doctors.DataSource = doctors;

		dataGridView_Doctors.Columns["id"].Visible = false;
	}

	private void Btn_Cadastrar_Doutor_Click(object sender, EventArgs e)
	{
		var form = new FormularioCadastrarDoutores();
		form.ShowDialog();
	}

	private void DataGridView_Doctors_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
	{
		if (e.RowIndex >= 0)
		{
			string id = dataGridView_Doctors.Rows[e.RowIndex].Cells["Id"].Value.ToString()!;
			string name = dataGridView_Doctors.Rows[e.RowIndex].Cells["Name"].Value.ToString()!;
			string? email = dataGridView_Doctors.Rows[e.RowIndex].Cells["Email"].Value.ToString()!;
			string cpf = dataGridView_Doctors.Rows[e.RowIndex].Cells["Cpf"].Value.ToString()!;
			string rg = dataGridView_Doctors.Rows[e.RowIndex].Cells["Rg"].Value.ToString()!;
			string address = dataGridView_Doctors.Rows[e.RowIndex].Cells["Address"].Value.ToString()!;
			string telephone = dataGridView_Doctors.Rows[e.RowIndex].Cells["Telephone"].Value.ToString()!;	
			string expertise = dataGridView_Doctors.Rows[e.RowIndex].Cells["Expertise"].Value.ToString()!;
			DateTime date_hire = Convert.ToDateTime(dataGridView_Doctors.Rows[e.RowIndex].Cells["Date_Hire"].Value);
			DateTime date_fire =Convert.ToDateTime(dataGridView_Doctors.Rows[e.RowIndex].Cells["Date_Fire"].Value);
			decimal value = (decimal)dataGridView_Doctors.Rows[e.RowIndex].Cells["Value"].Value;
			Expiration expiration = (Expiration)dataGridView_Doctors.Rows[e.RowIndex].Cells["Expiration"].Value;
			int sessions = (int)dataGridView_Doctors.Rows[e.RowIndex].Cells["Sessions"].Value;
			int work_hours = (int)dataGridView_Doctors.Rows[e.RowIndex].Cells["Work_hours"].Value;
			string turns = dataGridView_Doctors.Rows[e.RowIndex].Cells["Turns"].Value.ToString()!;
			string bankAccount = dataGridView_Doctors.Rows[e.RowIndex].Cells["BankAccount"].Value.ToString()!;


			var form = new FormularioCadastrarDoutores(id,name,email,cpf,rg,address,telephone,expertise,date_hire,date_fire, value, expiration, sessions,work_hours,turns,bankAccount);
			form.ShowDialog();
		}
	}
}
