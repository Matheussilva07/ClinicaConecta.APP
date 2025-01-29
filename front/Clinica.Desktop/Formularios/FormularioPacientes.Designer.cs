namespace Clinica.Desktop.Formularios;

partial class FormularioPacientes
{
	/// <summary>
	/// Required designer variable.
	/// </summary>
	private System.ComponentModel.IContainer components = null;

	/// <summary>
	/// Clean up any resources being used.
	/// </summary>
	/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
	protected override void Dispose(bool disposing)
	{
		if (disposing && (components != null))
		{
			components.Dispose();
		}
		base.Dispose(disposing);
	}

	#region Windows Form Designer generated code

	/// <summary>
	/// Required method for Designer support - do not modify
	/// the contents of this method with the code editor.
	/// </summary>
	private void InitializeComponent()
	{
		panel1 = new Panel();
		Btn_Cadastrar_Paciente = new Button();
		dataGridView1 = new DataGridView();
		panel1.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
		SuspendLayout();
		// 
		// panel1
		// 
		panel1.BackColor = Color.DarkSeaGreen;
		panel1.Controls.Add(Btn_Cadastrar_Paciente);
		panel1.Location = new Point(2, 0);
		panel1.Name = "panel1";
		panel1.Size = new Size(210, 499);
		panel1.TabIndex = 0;
		// 
		// Btn_Cadastrar_Paciente
		// 
		Btn_Cadastrar_Paciente.BackColor = Color.DarkSeaGreen;
		Btn_Cadastrar_Paciente.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
		Btn_Cadastrar_Paciente.ForeColor = SystemColors.ButtonHighlight;
		Btn_Cadastrar_Paciente.Location = new Point(31, 50);
		Btn_Cadastrar_Paciente.Name = "Btn_Cadastrar_Paciente";
		Btn_Cadastrar_Paciente.Size = new Size(137, 48);
		Btn_Cadastrar_Paciente.TabIndex = 1;
		Btn_Cadastrar_Paciente.Text = "Novo paciente";
		Btn_Cadastrar_Paciente.UseVisualStyleBackColor = false;
		Btn_Cadastrar_Paciente.Click += Btn_Cadastrar_Paciente_Click;
		// 
		// dataGridView1
		// 
		dataGridView1.BorderStyle = BorderStyle.None;
		dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		dataGridView1.Location = new Point(208, 0);
		dataGridView1.Name = "dataGridView1";
		dataGridView1.Size = new Size(651, 499);
		dataGridView1.TabIndex = 1;
		dataGridView1.CellMouseDoubleClick += DataGridView_Pacientes_CellMouseDoubleClick;
		// 
		// FormularioPacientes
		// 
		AutoScaleDimensions = new SizeF(7F, 15F);
		AutoScaleMode = AutoScaleMode.Font;
		ClientSize = new Size(861, 500);
		Controls.Add(dataGridView1);
		Controls.Add(panel1);
		MaximizeBox = false;
		MinimizeBox = false;
		Name = "FormularioPacientes";
		StartPosition = FormStartPosition.CenterScreen;
		Text = "FormularioPacientes";
		Load += FormularioPacientes_Load;
		panel1.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
		ResumeLayout(false);
	}

	#endregion

	private Panel panel1;
	private DataGridView dataGridView1;
	private Button Btn_Cadastrar_Paciente;
}