namespace Clinica.Desktop.Formularios;

partial class FormularioDoutores
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
		dataGridView_Doctors = new DataGridView();
		panel1 = new Panel();
		Btn_Cadastrar_Doutor = new Button();
		((System.ComponentModel.ISupportInitialize)dataGridView_Doctors).BeginInit();
		panel1.SuspendLayout();
		SuspendLayout();
		// 
		// dataGridView_Doctors
		// 
		dataGridView_Doctors.BorderStyle = BorderStyle.None;
		dataGridView_Doctors.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		dataGridView_Doctors.Location = new Point(209, 1);
		dataGridView_Doctors.Name = "dataGridView_Doctors";
		dataGridView_Doctors.Size = new Size(651, 499);
		dataGridView_Doctors.TabIndex = 3;
		dataGridView_Doctors.CellDoubleClick += DataGridView_Doctors_CellDoubleClick;
		// 
		// panel1
		// 
		panel1.BackColor = Color.DarkSeaGreen;
		panel1.Controls.Add(Btn_Cadastrar_Doutor);
		panel1.Location = new Point(3, 1);
		panel1.Name = "panel1";
		panel1.Size = new Size(210, 499);
		panel1.TabIndex = 2;
		// 
		// Btn_Cadastrar_Doutor
		// 
		Btn_Cadastrar_Doutor.BackColor = Color.DarkSeaGreen;
		Btn_Cadastrar_Doutor.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
		Btn_Cadastrar_Doutor.ForeColor = SystemColors.ButtonHighlight;
		Btn_Cadastrar_Doutor.Location = new Point(31, 50);
		Btn_Cadastrar_Doutor.Name = "Btn_Cadastrar_Doutor";
		Btn_Cadastrar_Doutor.Size = new Size(137, 48);
		Btn_Cadastrar_Doutor.TabIndex = 1;
		Btn_Cadastrar_Doutor.Text = "Novo";
		Btn_Cadastrar_Doutor.UseVisualStyleBackColor = false;
		Btn_Cadastrar_Doutor.Click += Btn_Cadastrar_Doutor_Click;
		// 
		// FormularioDoutores
		// 
		AutoScaleDimensions = new SizeF(7F, 15F);
		AutoScaleMode = AutoScaleMode.Font;
		ClientSize = new Size(863, 504);
		Controls.Add(dataGridView_Doctors);
		Controls.Add(panel1);
		Name = "FormularioDoutores";
		StartPosition = FormStartPosition.CenterScreen;
		Text = "FormularioDoutores";
		Load += FormularioDoutores_Load;
		((System.ComponentModel.ISupportInitialize)dataGridView_Doctors).EndInit();
		panel1.ResumeLayout(false);
		ResumeLayout(false);
	}

	#endregion

	private DataGridView dataGridView_Doctors;
	private Panel panel1;
	private Button Btn_Cadastrar_Doutor;
}