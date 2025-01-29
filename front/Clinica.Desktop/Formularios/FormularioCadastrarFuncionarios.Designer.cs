namespace Clinica.Desktop.Formularios;

partial class FormularioCadastrarFuncionarios
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
		Lbl_ID = new Label();
		label6 = new Label();
		Txt_Date_Hire = new DateTimePicker();
		label5 = new Label();
		label4 = new Label();
		label3 = new Label();
		label1 = new Label();
		Txt_Email = new TextBox();
		Txt_Address = new TextBox();
		Txt_Telephone = new MaskedTextBox();
		Txt_Name = new TextBox();
		Btn_Delete = new Button();
		Btn_Atualizar = new Button();
		Btn_Pesquisar = new Button();
		Btn_Cadastrar = new Button();
		Txt_CPF = new MaskedTextBox();
		label2 = new Label();
		Txt_RG = new TextBox();
		label7 = new Label();
		label8 = new Label();
		Txt_Function = new TextBox();
		Txt_Date_Fire = new DateTimePicker();
		label9 = new Label();
		label10 = new Label();
		Txt_WorkHours = new TextBox();
		label11 = new Label();
		Txt_Account = new TextBox();
		label12 = new Label();
		ComboBox_ContractType = new ComboBox();
		SuspendLayout();
		// 
		// Lbl_ID
		// 
		Lbl_ID.AutoSize = true;
		Lbl_ID.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
		Lbl_ID.Location = new Point(564, 15);
		Lbl_ID.Name = "Lbl_ID";
		Lbl_ID.Size = new Size(28, 18);
		Lbl_ID.TabIndex = 36;
		Lbl_ID.Text = "Id:";
		// 
		// label6
		// 
		label6.AutoSize = true;
		label6.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
		label6.Location = new Point(11, 215);
		label6.Name = "label6";
		label6.Size = new Size(91, 18);
		label6.TabIndex = 35;
		label6.Text = "Endereço:";
		// 
		// Txt_Date_Hire
		// 
		Txt_Date_Hire.CalendarFont = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
		Txt_Date_Hire.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
		Txt_Date_Hire.Format = DateTimePickerFormat.Short;
		Txt_Date_Hire.Location = new Point(108, 356);
		Txt_Date_Hire.Name = "Txt_Date_Hire";
		Txt_Date_Hire.Size = new Size(187, 26);
		Txt_Date_Hire.TabIndex = 34;
		// 
		// label5
		// 
		label5.AutoSize = true;
		label5.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
		label5.Location = new Point(11, 362);
		label5.Name = "label5";
		label5.Size = new Size(91, 18);
		label5.TabIndex = 33;
		label5.Text = "Admissão:";
		// 
		// label4
		// 
		label4.AutoSize = true;
		label4.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
		label4.Location = new Point(11, 68);
		label4.Name = "label4";
		label4.Size = new Size(56, 18);
		label4.TabIndex = 32;
		label4.Text = "Email:";
		// 
		// label3
		// 
		label3.AutoSize = true;
		label3.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
		label3.Location = new Point(11, 264);
		label3.Name = "label3";
		label3.Size = new Size(70, 18);
		label3.TabIndex = 31;
		label3.Text = "Celular:";
		// 
		// label1
		// 
		label1.AutoSize = true;
		label1.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
		label1.Location = new Point(11, 19);
		label1.Name = "label1";
		label1.Size = new Size(59, 18);
		label1.TabIndex = 29;
		label1.Text = "Nome:";
		// 
		// Txt_Email
		// 
		Txt_Email.Font = new Font("Arial Rounded MT Bold", 12F);
		Txt_Email.Location = new Point(76, 65);
		Txt_Email.Name = "Txt_Email";
		Txt_Email.Size = new Size(457, 26);
		Txt_Email.TabIndex = 28;
		// 
		// Txt_Address
		// 
		Txt_Address.Font = new Font("Arial Rounded MT Bold", 12F);
		Txt_Address.Location = new Point(108, 212);
		Txt_Address.Name = "Txt_Address";
		Txt_Address.Size = new Size(425, 26);
		Txt_Address.TabIndex = 27;
		// 
		// Txt_Telephone
		// 
		Txt_Telephone.Font = new Font("Arial Rounded MT Bold", 12F);
		Txt_Telephone.Location = new Point(108, 261);
		Txt_Telephone.Mask = "(00) 0 0000-0000";
		Txt_Telephone.Name = "Txt_Telephone";
		Txt_Telephone.Size = new Size(187, 26);
		Txt_Telephone.TabIndex = 26;
		// 
		// Txt_Name
		// 
		Txt_Name.Font = new Font("Arial Rounded MT Bold", 12F);
		Txt_Name.Location = new Point(76, 16);
		Txt_Name.Name = "Txt_Name";
		Txt_Name.Size = new Size(457, 26);
		Txt_Name.TabIndex = 24;
		// 
		// Btn_Delete
		// 
		Btn_Delete.BackColor = Color.DarkSeaGreen;
		Btn_Delete.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
		Btn_Delete.ForeColor = SystemColors.ButtonHighlight;
		Btn_Delete.Location = new Point(452, 608);
		Btn_Delete.Name = "Btn_Delete";
		Btn_Delete.Size = new Size(137, 48);
		Btn_Delete.TabIndex = 23;
		Btn_Delete.Text = "Deletar";
		Btn_Delete.UseVisualStyleBackColor = false;
		Btn_Delete.Click += Btn_Delete_Click;
		// 
		// Btn_Atualizar
		// 
		Btn_Atualizar.BackColor = Color.DarkSeaGreen;
		Btn_Atualizar.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
		Btn_Atualizar.ForeColor = SystemColors.ButtonHighlight;
		Btn_Atualizar.Location = new Point(309, 608);
		Btn_Atualizar.Name = "Btn_Atualizar";
		Btn_Atualizar.Size = new Size(137, 48);
		Btn_Atualizar.TabIndex = 22;
		Btn_Atualizar.Text = "Atualizar";
		Btn_Atualizar.UseVisualStyleBackColor = false;
		Btn_Atualizar.Click += Btn_Atualizar_Click;
		// 
		// Btn_Pesquisar
		// 
		Btn_Pesquisar.BackColor = Color.DarkSeaGreen;
		Btn_Pesquisar.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
		Btn_Pesquisar.ForeColor = SystemColors.ButtonHighlight;
		Btn_Pesquisar.Location = new Point(166, 608);
		Btn_Pesquisar.Name = "Btn_Pesquisar";
		Btn_Pesquisar.Size = new Size(137, 48);
		Btn_Pesquisar.TabIndex = 21;
		Btn_Pesquisar.Text = "Pesquisar";
		Btn_Pesquisar.UseVisualStyleBackColor = false;
		Btn_Pesquisar.Click += Btn_Pesquisar_Click;
		// 
		// Btn_Cadastrar
		// 
		Btn_Cadastrar.BackColor = Color.DarkSeaGreen;
		Btn_Cadastrar.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
		Btn_Cadastrar.ForeColor = SystemColors.ButtonHighlight;
		Btn_Cadastrar.Location = new Point(23, 608);
		Btn_Cadastrar.Name = "Btn_Cadastrar";
		Btn_Cadastrar.Size = new Size(137, 48);
		Btn_Cadastrar.TabIndex = 20;
		Btn_Cadastrar.Text = "Cadastrar";
		Btn_Cadastrar.UseVisualStyleBackColor = false;
		Btn_Cadastrar.Click += Btn_Cadastrar_Click;
		// 
		// Txt_CPF
		// 
		Txt_CPF.Font = new Font("Arial Rounded MT Bold", 12F);
		Txt_CPF.Location = new Point(76, 114);
		Txt_CPF.Mask = "000.000.000-00";
		Txt_CPF.Name = "Txt_CPF";
		Txt_CPF.Size = new Size(211, 26);
		Txt_CPF.TabIndex = 25;
		// 
		// label2
		// 
		label2.AutoSize = true;
		label2.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
		label2.Location = new Point(11, 117);
		label2.Name = "label2";
		label2.Size = new Size(46, 18);
		label2.TabIndex = 30;
		label2.Text = "CPF:";
		// 
		// Txt_RG
		// 
		Txt_RG.Font = new Font("Arial Rounded MT Bold", 12F);
		Txt_RG.Location = new Point(76, 163);
		Txt_RG.Name = "Txt_RG";
		Txt_RG.Size = new Size(211, 26);
		Txt_RG.TabIndex = 37;
		// 
		// label7
		// 
		label7.AutoSize = true;
		label7.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
		label7.Location = new Point(11, 166);
		label7.Name = "label7";
		label7.Size = new Size(38, 18);
		label7.TabIndex = 38;
		label7.Text = "RG:";
		// 
		// label8
		// 
		label8.AutoSize = true;
		label8.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
		label8.Location = new Point(11, 313);
		label8.Name = "label8";
		label8.Size = new Size(73, 18);
		label8.TabIndex = 40;
		label8.Text = "Função:";
		// 
		// Txt_Function
		// 
		Txt_Function.Font = new Font("Arial Rounded MT Bold", 12F);
		Txt_Function.Location = new Point(108, 310);
		Txt_Function.Name = "Txt_Function";
		Txt_Function.Size = new Size(187, 26);
		Txt_Function.TabIndex = 39;
		// 
		// Txt_Date_Fire
		// 
		Txt_Date_Fire.CalendarFont = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
		Txt_Date_Fire.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
		Txt_Date_Fire.Format = DateTimePickerFormat.Short;
		Txt_Date_Fire.Location = new Point(108, 405);
		Txt_Date_Fire.Name = "Txt_Date_Fire";
		Txt_Date_Fire.Size = new Size(187, 26);
		Txt_Date_Fire.TabIndex = 42;
		// 
		// label9
		// 
		label9.AutoSize = true;
		label9.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
		label9.Location = new Point(11, 411);
		label9.Name = "label9";
		label9.Size = new Size(91, 18);
		label9.TabIndex = 41;
		label9.Text = "Demissão:";
		// 
		// label10
		// 
		label10.AutoSize = true;
		label10.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
		label10.Location = new Point(11, 509);
		label10.Name = "label10";
		label10.Size = new Size(124, 18);
		label10.TabIndex = 44;
		label10.Text = "Carga horária:";
		// 
		// Txt_WorkHours
		// 
		Txt_WorkHours.Font = new Font("Arial Rounded MT Bold", 12F);
		Txt_WorkHours.Location = new Point(135, 506);
		Txt_WorkHours.Name = "Txt_WorkHours";
		Txt_WorkHours.Size = new Size(239, 26);
		Txt_WorkHours.TabIndex = 43;
		// 
		// label11
		// 
		label11.AutoSize = true;
		label11.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
		label11.Location = new Point(11, 558);
		label11.Name = "label11";
		label11.Size = new Size(61, 18);
		label11.TabIndex = 46;
		label11.Text = "Conta:";
		// 
		// Txt_Account
		// 
		Txt_Account.Font = new Font("Arial Rounded MT Bold", 12F);
		Txt_Account.Location = new Point(135, 555);
		Txt_Account.Name = "Txt_Account";
		Txt_Account.Size = new Size(239, 26);
		Txt_Account.TabIndex = 45;
		// 
		// label12
		// 
		label12.AutoSize = true;
		label12.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
		label12.Location = new Point(11, 460);
		label12.Name = "label12";
		label12.Size = new Size(84, 18);
		label12.TabIndex = 47;
		label12.Text = "Contrato:";
		// 
		// ComboBox_ContractType
		// 
		ComboBox_ContractType.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
		ComboBox_ContractType.FormattingEnabled = true;
		ComboBox_ContractType.Items.AddRange(new object[] { "CLT", "PJ", "Estágio", "Diária" });
		ComboBox_ContractType.Location = new Point(108, 457);
		ComboBox_ContractType.Name = "ComboBox_ContractType";
		ComboBox_ContractType.Size = new Size(187, 26);
		ComboBox_ContractType.TabIndex = 48;
		// 
		// FormularioCadastrarFuncionarios
		// 
		AutoScaleDimensions = new SizeF(7F, 15F);
		AutoScaleMode = AutoScaleMode.Font;
		ClientSize = new Size(613, 680);
		Controls.Add(ComboBox_ContractType);
		Controls.Add(label12);
		Controls.Add(label11);
		Controls.Add(Txt_Account);
		Controls.Add(label10);
		Controls.Add(Txt_WorkHours);
		Controls.Add(Txt_Date_Fire);
		Controls.Add(label9);
		Controls.Add(label8);
		Controls.Add(Txt_Function);
		Controls.Add(label7);
		Controls.Add(Txt_RG);
		Controls.Add(Lbl_ID);
		Controls.Add(label6);
		Controls.Add(Txt_Date_Hire);
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
		Controls.Add(Btn_Delete);
		Controls.Add(Btn_Atualizar);
		Controls.Add(Btn_Pesquisar);
		Controls.Add(Btn_Cadastrar);
		Name = "FormularioCadastrarFuncionarios";
		StartPosition = FormStartPosition.CenterScreen;
		Text = "FormularioCadastrarFuncionarios";
		Load += FormularioCadastrarFuncionarios_Load;
		ResumeLayout(false);
		PerformLayout();
	}

	#endregion

	private Label Lbl_ID;
	private Label label6;
	private DateTimePicker Txt_Date_Hire;
	private Label label5;
	private Label label4;
	private Label label3;
	private Label label1;
	private TextBox Txt_Email;
	private TextBox Txt_Address;
	private MaskedTextBox Txt_Telephone;
	private TextBox Txt_Name;
	private Button Btn_Delete;
	private Button Btn_Atualizar;
	private Button Btn_Pesquisar;
	private Button Btn_Cadastrar;
	private MaskedTextBox Txt_CPF;
	private Label label2;
	private TextBox Txt_RG;
	private Label label7;
	private Label label8;
	private TextBox Txt_Function;
	private DateTimePicker Txt_Date_Fire;
	private Label label9;
	private Label label10;
	private TextBox Txt_WorkHours;
	private Label label11;
	private TextBox Txt_Account;
	private Label label12;
	private ComboBox ComboBox_ContractType;
}