namespace Clinica.Desktop.Formularios;

partial class FormularioCadastrarPacientes
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
		Btn_Cadastrar_Pacientes = new Button();
		Btn_Pesquisar_Pacientes = new Button();
		Btn_Atualizar_Pacientes = new Button();
		Btn_Delete_Pacientes = new Button();
		Txt_Name = new TextBox();
		Txt_CPF = new MaskedTextBox();
		Txt_Telephone = new MaskedTextBox();
		Txt_Address = new TextBox();
		Txt_Email = new TextBox();
		label1 = new Label();
		label2 = new Label();
		label3 = new Label();
		label4 = new Label();
		label5 = new Label();
		Txt_Birth = new DateTimePicker();
		label6 = new Label();
		Lbl_ID = new Label();
		SuspendLayout();
		// 
		// Btn_Cadastrar_Pacientes
		// 
		Btn_Cadastrar_Pacientes.BackColor = Color.DarkSeaGreen;
		Btn_Cadastrar_Pacientes.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
		Btn_Cadastrar_Pacientes.ForeColor = SystemColors.ButtonHighlight;
		Btn_Cadastrar_Pacientes.Location = new Point(14, 296);
		Btn_Cadastrar_Pacientes.Name = "Btn_Cadastrar_Pacientes";
		Btn_Cadastrar_Pacientes.Size = new Size(137, 48);
		Btn_Cadastrar_Pacientes.TabIndex = 2;
		Btn_Cadastrar_Pacientes.Text = "Cadastrar";
		Btn_Cadastrar_Pacientes.UseVisualStyleBackColor = false;
		Btn_Cadastrar_Pacientes.Click += Btn_Cadastrar_Paciente_Click;
		// 
		// Btn_Pesquisar_Pacientes
		// 
		Btn_Pesquisar_Pacientes.BackColor = Color.DarkSeaGreen;
		Btn_Pesquisar_Pacientes.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
		Btn_Pesquisar_Pacientes.ForeColor = SystemColors.ButtonHighlight;
		Btn_Pesquisar_Pacientes.Location = new Point(157, 296);
		Btn_Pesquisar_Pacientes.Name = "Btn_Pesquisar_Pacientes";
		Btn_Pesquisar_Pacientes.Size = new Size(137, 48);
		Btn_Pesquisar_Pacientes.TabIndex = 3;
		Btn_Pesquisar_Pacientes.Text = "Pesquisar";
		Btn_Pesquisar_Pacientes.UseVisualStyleBackColor = false;
		Btn_Pesquisar_Pacientes.Click += Btn_Pesquisar_Pacientes_Click;
		// 
		// Btn_Atualizar_Pacientes
		// 
		Btn_Atualizar_Pacientes.BackColor = Color.DarkSeaGreen;
		Btn_Atualizar_Pacientes.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
		Btn_Atualizar_Pacientes.ForeColor = SystemColors.ButtonHighlight;
		Btn_Atualizar_Pacientes.Location = new Point(300, 296);
		Btn_Atualizar_Pacientes.Name = "Btn_Atualizar_Pacientes";
		Btn_Atualizar_Pacientes.Size = new Size(137, 48);
		Btn_Atualizar_Pacientes.TabIndex = 4;
		Btn_Atualizar_Pacientes.Text = "Atualizar";
		Btn_Atualizar_Pacientes.UseVisualStyleBackColor = false;
		Btn_Atualizar_Pacientes.Click += Btn_Atualizar_Paciente_Click;
		// 
		// Btn_Delete_Pacientes
		// 
		Btn_Delete_Pacientes.BackColor = Color.DarkSeaGreen;
		Btn_Delete_Pacientes.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
		Btn_Delete_Pacientes.ForeColor = SystemColors.ButtonHighlight;
		Btn_Delete_Pacientes.Location = new Point(443, 296);
		Btn_Delete_Pacientes.Name = "Btn_Delete_Pacientes";
		Btn_Delete_Pacientes.Size = new Size(137, 48);
		Btn_Delete_Pacientes.TabIndex = 5;
		Btn_Delete_Pacientes.Text = "Deletar";
		Btn_Delete_Pacientes.UseVisualStyleBackColor = false;
		Btn_Delete_Pacientes.Click += Btn_Deletar_Pacientes_Click;
		// 
		// Txt_Name
		// 
		Txt_Name.Font = new Font("Arial Rounded MT Bold", 12F);
		Txt_Name.Location = new Point(111, 20);
		Txt_Name.Name = "Txt_Name";
		Txt_Name.Size = new Size(457, 26);
		Txt_Name.TabIndex = 6;
		// 
		// Txt_CPF
		// 
		Txt_CPF.Font = new Font("Arial Rounded MT Bold", 12F);
		Txt_CPF.Location = new Point(111, 140);
		Txt_CPF.Mask = "000.000.000-00";
		Txt_CPF.Name = "Txt_CPF";
		Txt_CPF.Size = new Size(211, 26);
		Txt_CPF.TabIndex = 7;
		// 
		// Txt_Telephone
		// 
		Txt_Telephone.Font = new Font("Arial Rounded MT Bold", 12F);
		Txt_Telephone.Location = new Point(111, 100);
		Txt_Telephone.Mask = "(00) 0 0000-0000";
		Txt_Telephone.Name = "Txt_Telephone";
		Txt_Telephone.Size = new Size(211, 26);
		Txt_Telephone.TabIndex = 8;
		// 
		// Txt_Address
		// 
		Txt_Address.Font = new Font("Arial Rounded MT Bold", 12F);
		Txt_Address.Location = new Point(118, 220);
		Txt_Address.Name = "Txt_Address";
		Txt_Address.Size = new Size(450, 26);
		Txt_Address.TabIndex = 10;
		// 
		// Txt_Email
		// 
		Txt_Email.Font = new Font("Arial Rounded MT Bold", 12F);
		Txt_Email.Location = new Point(111, 60);
		Txt_Email.Name = "Txt_Email";
		Txt_Email.Size = new Size(457, 26);
		Txt_Email.TabIndex = 11;
		// 
		// label1
		// 
		label1.AutoSize = true;
		label1.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
		label1.Location = new Point(21, 23);
		label1.Name = "label1";
		label1.Size = new Size(59, 18);
		label1.TabIndex = 12;
		label1.Text = "Nome:";
		// 
		// label2
		// 
		label2.AutoSize = true;
		label2.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
		label2.Location = new Point(21, 143);
		label2.Name = "label2";
		label2.Size = new Size(46, 18);
		label2.TabIndex = 13;
		label2.Text = "CPF:";
		// 
		// label3
		// 
		label3.AutoSize = true;
		label3.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
		label3.Location = new Point(21, 103);
		label3.Name = "label3";
		label3.Size = new Size(70, 18);
		label3.TabIndex = 14;
		label3.Text = "Celular:";
		// 
		// label4
		// 
		label4.AutoSize = true;
		label4.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
		label4.Location = new Point(21, 63);
		label4.Name = "label4";
		label4.Size = new Size(56, 18);
		label4.TabIndex = 15;
		label4.Text = "Email:";
		// 
		// label5
		// 
		label5.AutoSize = true;
		label5.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
		label5.Location = new Point(21, 183);
		label5.Name = "label5";
		label5.Size = new Size(108, 18);
		label5.TabIndex = 16;
		label5.Text = "Nascimento:";
		// 
		// Txt_Birth
		// 
		Txt_Birth.CalendarFont = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
		Txt_Birth.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
		Txt_Birth.Format = DateTimePickerFormat.Short;
		Txt_Birth.Location = new Point(135, 180);
		Txt_Birth.Name = "Txt_Birth";
		Txt_Birth.Size = new Size(187, 26);
		Txt_Birth.TabIndex = 17;
		// 
		// label6
		// 
		label6.AutoSize = true;
		label6.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
		label6.Location = new Point(21, 223);
		label6.Name = "label6";
		label6.Size = new Size(91, 18);
		label6.TabIndex = 18;
		label6.Text = "Endereço:";
		// 
		// Lbl_ID
		// 
		Lbl_ID.AutoSize = true;
		Lbl_ID.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
		Lbl_ID.Location = new Point(574, 23);
		Lbl_ID.Name = "Lbl_ID";
		Lbl_ID.Size = new Size(28, 18);
		Lbl_ID.TabIndex = 19;
		Lbl_ID.Text = "Id:";
		Lbl_ID.Visible = false;
		// 
		// FormularioCadastrarPacientes
		// 
		AutoScaleDimensions = new SizeF(7F, 15F);
		AutoScaleMode = AutoScaleMode.Font;
		ClientSize = new Size(595, 368);
		Controls.Add(Lbl_ID);
		Controls.Add(label6);
		Controls.Add(Txt_Birth);
		Controls.Add(label5);
		Controls.Add(label4);
		Controls.Add(label3);
		Controls.Add(label2);
		Controls.Add(label1);
		Controls.Add(Txt_Email);
		Controls.Add(Txt_Address);
		Controls.Add(Txt_Telephone);
		Controls.Add(Txt_CPF);
		Controls.Add(Txt_Name);
		Controls.Add(Btn_Delete_Pacientes);
		Controls.Add(Btn_Atualizar_Pacientes);
		Controls.Add(Btn_Pesquisar_Pacientes);
		Controls.Add(Btn_Cadastrar_Pacientes);
		FormBorderStyle = FormBorderStyle.FixedSingle;
		Name = "FormularioCadastrarPacientes";
		StartPosition = FormStartPosition.CenterScreen;
		Text = "FormularioCadastrarPacientes";
		Load += FormularioCadastrarPacientes_Load;
		ResumeLayout(false);
		PerformLayout();
	}

	#endregion

	private Button Btn_Cadastrar_Pacientes;
	private Button Btn_Pesquisar_Pacientes;
	private Button Btn_Atualizar_Pacientes;
	private Button Btn_Delete_Pacientes;
	private TextBox Txt_Name;
	private MaskedTextBox Txt_CPF;
	private MaskedTextBox Txt_Telephone;
	private TextBox Txt_Address;
	private TextBox Txt_Email;
	private Label label1;
	private Label label2;
	private Label label3;
	private Label label4;
	private Label label5;
	private DateTimePicker Txt_Birth;
	private Label label6;
	private Label Lbl_ID;
}