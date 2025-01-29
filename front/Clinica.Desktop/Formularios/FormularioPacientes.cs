using Clinica.Desktop.HTTP_Pacientes;

namespace Clinica.Desktop.Formularios;
public partial class FormularioPacientes : Form
{
	public FormularioPacientes()
	{
		InitializeComponent();
	}

	private void Btn_Cadastrar_Paciente_Click(object sender, EventArgs e)
	{
		var form = new FormularioCadastrarPacientes();
		form.ShowDialog();
	}

	private async void FormularioPacientes_Load(object sender, EventArgs e)
	{
		var pacientes = await HttpClient_Pacientes.DoGetAll();

		dataGridView1.DataSource = pacientes;

		dataGridView1.Columns["Id"].Visible = false;
	}
	private void DataGridView_Pacientes_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
	{
		if (e.RowIndex >= 0)
		{
			string Id = dataGridView1.Rows[e.RowIndex].Cells["Id"].Value.ToString()!;
			string Name = dataGridView1.Rows[e.RowIndex].Cells["Name"].Value.ToString()!;
			string? Email = dataGridView1.Rows[e.RowIndex].Cells["Email"].Value.ToString()!;
			string Telephone = dataGridView1.Rows[e.RowIndex].Cells["Telephone"].Value.ToString()!;
			string CPF = dataGridView1.Rows[e.RowIndex].Cells["CPF"].Value.ToString()!;
			string Address = dataGridView1.Rows[e.RowIndex].Cells["Address"].Value.ToString()!;
			DateTime Birth = Convert.ToDateTime(dataGridView1.Rows[e.RowIndex].Cells["Birth"].Value)!;

			var form = new FormularioCadastrarPacientes(Id,Name, Email,Telephone, CPF,Address, Birth);
			form.ShowDialog();
		}
	}
}
