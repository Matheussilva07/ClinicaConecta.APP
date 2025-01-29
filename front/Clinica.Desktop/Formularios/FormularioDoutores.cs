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
}
