using Clinica.Desktop.Formularios;

namespace Clinica.Desktop;

public partial class Principal : Form
{
	public Principal()
	{
		InitializeComponent();
	}

	private void Btn_PacientesForm_Click(object sender, EventArgs e)
	{
		var form = new FormularioPacientes();
		this.Opacity = 0.3;
		form.ShowDialog();
		this.Opacity = 1;
	}

	private void Btn_Funcionarios_Click(object sender, EventArgs e)
	{
		var form = new FormularioFuncionarios();
		this.Opacity = 0.3;
		form.ShowDialog();
		this.Opacity = 1;
	}

	private void Btn_Doutores_Click(object sender, EventArgs e)
	{
		var form = new FormularioDoutores();
		this.Opacity = 0.3;
		form.ShowDialog();
		this.Opacity = 1;
	}

	private void Btn_Consultas_Click(object sender, EventArgs e)
	{
		var form = new FormularioConsultas();
		this.Opacity = 0.3;
		form.ShowDialog();
		this.Opacity = 1;
	}
}
