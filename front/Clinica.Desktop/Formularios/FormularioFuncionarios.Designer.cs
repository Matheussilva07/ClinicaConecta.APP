namespace Clinica.Desktop.Formularios;

partial class FormularioFuncionarios
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
		Btn_Cadastrar_Funcionarios = new Button();
		dataGridView_Funcionarios = new DataGridView();
		panel1.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)dataGridView_Funcionarios).BeginInit();
		SuspendLayout();
		// 
		// panel1
		// 
		panel1.BackColor = Color.DarkSeaGreen;
		panel1.Controls.Add(Btn_Cadastrar_Funcionarios);
		panel1.Location = new Point(1, -1);
		panel1.Name = "panel1";
		panel1.Size = new Size(209, 500);
		panel1.TabIndex = 1;
		// 
		// Btn_Cadastrar_Funcionarios
		// 
		Btn_Cadastrar_Funcionarios.BackColor = Color.DarkSeaGreen;
		Btn_Cadastrar_Funcionarios.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
		Btn_Cadastrar_Funcionarios.ForeColor = SystemColors.ButtonHighlight;
		Btn_Cadastrar_Funcionarios.Location = new Point(31, 50);
		Btn_Cadastrar_Funcionarios.Name = "Btn_Cadastrar_Funcionarios";
		Btn_Cadastrar_Funcionarios.Size = new Size(137, 48);
		Btn_Cadastrar_Funcionarios.TabIndex = 1;
		Btn_Cadastrar_Funcionarios.Text = "Novo ";
		Btn_Cadastrar_Funcionarios.UseVisualStyleBackColor = false;
		Btn_Cadastrar_Funcionarios.Click += Btn_Cadastrar_Funcionarios_Click;
		// 
		// dataGridView_Funcionarios
		// 
		dataGridView_Funcionarios.BorderStyle = BorderStyle.None;
		dataGridView_Funcionarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		dataGridView_Funcionarios.Location = new Point(207, -1);
		dataGridView_Funcionarios.Name = "dataGridView_Funcionarios";
		dataGridView_Funcionarios.Size = new Size(652, 500);
		dataGridView_Funcionarios.TabIndex = 2;
		dataGridView_Funcionarios.CellMouseDoubleClick += DataGridView_Funcionarios_CellMouseDoubleClick;
		// 
		// FormularioFuncionarios
		// 
		AutoScaleDimensions = new SizeF(7F, 15F);
		AutoScaleMode = AutoScaleMode.Font;
		ClientSize = new Size(861, 500);
		Controls.Add(dataGridView_Funcionarios);
		Controls.Add(panel1);
		FormBorderStyle = FormBorderStyle.Fixed3D;
		MaximizeBox = false;
		MinimizeBox = false;
		Name = "FormularioFuncionarios";
		StartPosition = FormStartPosition.CenterScreen;
		Text = "FormularioFuncionarios";
		Load += FormularioFuncionarios_Load;
		panel1.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)dataGridView_Funcionarios).EndInit();
		ResumeLayout(false);
	}

	#endregion

	private Panel panel1;
	private Button Btn_Cadastrar_Funcionarios;
	private DataGridView dataGridView_Funcionarios;
}