namespace Clinica.Desktop.Formularios;

partial class FormularioConsultas
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormularioConsultas));
		groupBox1 = new GroupBox();
		button1 = new Button();
		txt_Celular = new MaskedTextBox();
		txt_CPF = new MaskedTextBox();
		label3 = new Label();
		label2 = new Label();
		txt_Nome = new TextBox();
		label1 = new Label();
		groupBox2 = new GroupBox();
		txt_Servico = new TextBox();
		label4 = new Label();
		groupBox3 = new GroupBox();
		txt_Especialidade = new TextBox();
		label9 = new Label();
		txt_Nome_Profissional = new TextBox();
		label8 = new Label();
		groupBox4 = new GroupBox();
		comboBox_Horarios_Consultas = new ComboBox();
		monthCalendar_Data_Consultas = new MonthCalendar();
		label7 = new Label();
		groupBox5 = new GroupBox();
		txt_Desconto = new TextBox();
		label6 = new Label();
		comboBox_Formas_Pagamento = new ComboBox();
		txt_Valor = new TextBox();
		label10 = new Label();
		label11 = new Label();
		Btn_Cadastrar = new Button();
		Btn_Pesquisar_Profissional = new Button();
		groupBox1.SuspendLayout();
		groupBox2.SuspendLayout();
		groupBox3.SuspendLayout();
		groupBox4.SuspendLayout();
		groupBox5.SuspendLayout();
		SuspendLayout();
		// 
		// groupBox1
		// 
		groupBox1.BackColor = SystemColors.ButtonFace;
		groupBox1.Controls.Add(button1);
		groupBox1.Controls.Add(txt_Celular);
		groupBox1.Controls.Add(txt_CPF);
		groupBox1.Controls.Add(label3);
		groupBox1.Controls.Add(label2);
		groupBox1.Controls.Add(txt_Nome);
		groupBox1.Controls.Add(label1);
		groupBox1.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
		groupBox1.Location = new Point(12, 56);
		groupBox1.Name = "groupBox1";
		groupBox1.Size = new Size(783, 91);
		groupBox1.TabIndex = 1;
		groupBox1.TabStop = false;
		groupBox1.Text = "PACIENTE";
		// 
		// button1
		// 
		button1.ForeColor = SystemColors.ControlText;
		button1.Image = (Image)resources.GetObject("button1.Image");
		button1.Location = new Point(742, 13);
		button1.Name = "button1";
		button1.Size = new Size(35, 33);
		button1.TabIndex = 7;
		button1.UseVisualStyleBackColor = true;
		button1.Click += Btn_Pesquisar_Pacientes_Click;
		// 
		// txt_Celular
		// 
		txt_Celular.Location = new Point(581, 52);
		txt_Celular.Mask = "(00) 0 0000-0000";
		txt_Celular.Name = "txt_Celular";
		txt_Celular.Size = new Size(182, 26);
		txt_Celular.TabIndex = 6;
		// 
		// txt_CPF
		// 
		txt_CPF.Location = new Point(393, 52);
		txt_CPF.Mask = "000.000.000-00";
		txt_CPF.Name = "txt_CPF";
		txt_CPF.Size = new Size(182, 26);
		txt_CPF.TabIndex = 5;
		// 
		// label3
		// 
		label3.AutoSize = true;
		label3.Font = new Font("Arial", 12F);
		label3.Location = new Point(581, 31);
		label3.Name = "label3";
		label3.Size = new Size(61, 18);
		label3.TabIndex = 4;
		label3.Text = "Celular:";
		// 
		// label2
		// 
		label2.AutoSize = true;
		label2.Font = new Font("Arial", 12F);
		label2.Location = new Point(393, 31);
		label2.Name = "label2";
		label2.Size = new Size(45, 18);
		label2.TabIndex = 2;
		label2.Text = "CPF:";
		// 
		// txt_Nome
		// 
		txt_Nome.Location = new Point(6, 52);
		txt_Nome.Name = "txt_Nome";
		txt_Nome.Size = new Size(381, 26);
		txt_Nome.TabIndex = 1;
		// 
		// label1
		// 
		label1.AutoSize = true;
		label1.Font = new Font("Arial", 12F);
		label1.Location = new Point(7, 31);
		label1.Name = "label1";
		label1.Size = new Size(54, 18);
		label1.TabIndex = 0;
		label1.Text = "Nome:";
		// 
		// groupBox2
		// 
		groupBox2.BackColor = SystemColors.ButtonFace;
		groupBox2.Controls.Add(txt_Servico);
		groupBox2.Controls.Add(label4);
		groupBox2.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
		groupBox2.Location = new Point(12, 153);
		groupBox2.Name = "groupBox2";
		groupBox2.Size = new Size(783, 91);
		groupBox2.TabIndex = 2;
		groupBox2.TabStop = false;
		groupBox2.Text = "SERVIÇO";
		// 
		// txt_Servico
		// 
		txt_Servico.Location = new Point(7, 55);
		txt_Servico.Name = "txt_Servico";
		txt_Servico.Size = new Size(257, 26);
		txt_Servico.TabIndex = 8;
		// 
		// label4
		// 
		label4.AutoSize = true;
		label4.Font = new Font("Arial", 12F);
		label4.Location = new Point(8, 34);
		label4.Name = "label4";
		label4.Size = new Size(65, 18);
		label4.TabIndex = 7;
		label4.Text = "Serviço:";
		// 
		// groupBox3
		// 
		groupBox3.BackColor = SystemColors.ButtonFace;
		groupBox3.Controls.Add(Btn_Pesquisar_Profissional);
		groupBox3.Controls.Add(txt_Especialidade);
		groupBox3.Controls.Add(label9);
		groupBox3.Controls.Add(txt_Nome_Profissional);
		groupBox3.Controls.Add(label8);
		groupBox3.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
		groupBox3.Location = new Point(12, 250);
		groupBox3.Name = "groupBox3";
		groupBox3.Size = new Size(783, 91);
		groupBox3.TabIndex = 2;
		groupBox3.TabStop = false;
		groupBox3.Text = "PROFISSIONAL";
		// 
		// txt_Especialidade
		// 
		txt_Especialidade.Location = new Point(324, 48);
		txt_Especialidade.Name = "txt_Especialidade";
		txt_Especialidade.Size = new Size(223, 26);
		txt_Especialidade.TabIndex = 10;
		// 
		// label9
		// 
		label9.AutoSize = true;
		label9.Font = new Font("Arial", 12F);
		label9.Location = new Point(325, 27);
		label9.Name = "label9";
		label9.Size = new Size(113, 18);
		label9.TabIndex = 9;
		label9.Text = "Especialidade:";
		// 
		// txt_Nome_Profissional
		// 
		txt_Nome_Profissional.Location = new Point(8, 48);
		txt_Nome_Profissional.Name = "txt_Nome_Profissional";
		txt_Nome_Profissional.Size = new Size(310, 26);
		txt_Nome_Profissional.TabIndex = 8;
		// 
		// label8
		// 
		label8.AutoSize = true;
		label8.Font = new Font("Arial", 12F);
		label8.Location = new Point(9, 27);
		label8.Name = "label8";
		label8.Size = new Size(54, 18);
		label8.TabIndex = 7;
		label8.Text = "Nome:";
		// 
		// groupBox4
		// 
		groupBox4.BackColor = SystemColors.ButtonFace;
		groupBox4.Controls.Add(comboBox_Horarios_Consultas);
		groupBox4.Controls.Add(monthCalendar_Data_Consultas);
		groupBox4.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
		groupBox4.Location = new Point(12, 347);
		groupBox4.Name = "groupBox4";
		groupBox4.Size = new Size(783, 212);
		groupBox4.TabIndex = 3;
		groupBox4.TabStop = false;
		groupBox4.Text = "AGENDAMENTO";
		// 
		// comboBox_Horarios_Consultas
		// 
		comboBox_Horarios_Consultas.FormattingEnabled = true;
		comboBox_Horarios_Consultas.Items.AddRange(new object[] { "07:00", "08:00", "09:00", "10:00", "11:00", "12:00", "14:00", "15:00", "16:00", "17:00", "18:00" });
		comboBox_Horarios_Consultas.Location = new Point(270, 31);
		comboBox_Horarios_Consultas.Name = "comboBox_Horarios_Consultas";
		comboBox_Horarios_Consultas.Size = new Size(182, 26);
		comboBox_Horarios_Consultas.TabIndex = 1;
		// 
		// monthCalendar_Data_Consultas
		// 
		monthCalendar_Data_Consultas.Location = new Point(13, 31);
		monthCalendar_Data_Consultas.Name = "monthCalendar_Data_Consultas";
		monthCalendar_Data_Consultas.TabIndex = 0;
		// 
		// label7
		// 
		label7.AutoSize = true;
		label7.Font = new Font("Arial Rounded MT Bold", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
		label7.Location = new Point(243, 10);
		label7.Name = "label7";
		label7.Size = new Size(328, 28);
		label7.TabIndex = 4;
		label7.Text = "Agendamento de Consultas";
		// 
		// groupBox5
		// 
		groupBox5.BackColor = SystemColors.ButtonFace;
		groupBox5.Controls.Add(txt_Desconto);
		groupBox5.Controls.Add(label6);
		groupBox5.Controls.Add(comboBox_Formas_Pagamento);
		groupBox5.Controls.Add(txt_Valor);
		groupBox5.Controls.Add(label10);
		groupBox5.Controls.Add(label11);
		groupBox5.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
		groupBox5.Location = new Point(12, 567);
		groupBox5.Name = "groupBox5";
		groupBox5.Size = new Size(783, 91);
		groupBox5.TabIndex = 5;
		groupBox5.TabStop = false;
		groupBox5.Text = "PAGAMENTO";
		// 
		// txt_Desconto
		// 
		txt_Desconto.Location = new Point(506, 48);
		txt_Desconto.Name = "txt_Desconto";
		txt_Desconto.Size = new Size(257, 26);
		txt_Desconto.TabIndex = 14;
		txt_Desconto.Tag = "";
		// 
		// label6
		// 
		label6.AutoSize = true;
		label6.Font = new Font("Arial", 12F);
		label6.Location = new Point(506, 27);
		label6.Name = "label6";
		label6.Size = new Size(79, 18);
		label6.TabIndex = 13;
		label6.Text = "Desconto:";
		// 
		// comboBox_Formas_Pagamento
		// 
		comboBox_Formas_Pagamento.FormattingEnabled = true;
		comboBox_Formas_Pagamento.Items.AddRange(new object[] { "DINHEIRO", "PIX", "CRÉDITO", "DÉBITO" });
		comboBox_Formas_Pagamento.Location = new Point(6, 48);
		comboBox_Formas_Pagamento.Name = "comboBox_Formas_Pagamento";
		comboBox_Formas_Pagamento.Size = new Size(265, 26);
		comboBox_Formas_Pagamento.TabIndex = 2;
		// 
		// txt_Valor
		// 
		txt_Valor.Location = new Point(277, 48);
		txt_Valor.Name = "txt_Valor";
		txt_Valor.Size = new Size(223, 26);
		txt_Valor.TabIndex = 10;
		// 
		// label10
		// 
		label10.AutoSize = true;
		label10.Font = new Font("Arial", 12F);
		label10.Location = new Point(277, 22);
		label10.Name = "label10";
		label10.Size = new Size(48, 18);
		label10.TabIndex = 9;
		label10.Text = "Valor:";
		// 
		// label11
		// 
		label11.AutoSize = true;
		label11.Font = new Font("Arial", 12F);
		label11.Location = new Point(9, 27);
		label11.Name = "label11";
		label11.Size = new Size(58, 18);
		label11.TabIndex = 7;
		label11.Text = "Forma:";
		// 
		// Btn_Cadastrar
		// 
		Btn_Cadastrar.BackColor = Color.DarkSeaGreen;
		Btn_Cadastrar.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
		Btn_Cadastrar.ForeColor = SystemColors.ButtonHighlight;
		Btn_Cadastrar.Location = new Point(12, 683);
		Btn_Cadastrar.Name = "Btn_Cadastrar";
		Btn_Cadastrar.Size = new Size(137, 48);
		Btn_Cadastrar.TabIndex = 50;
		Btn_Cadastrar.Text = "Salvar";
		Btn_Cadastrar.UseVisualStyleBackColor = false;
		Btn_Cadastrar.Click += Btn_Salvar_Agendamento_Click;
		// 
		// Btn_Pesquisar_Profissional
		// 
		Btn_Pesquisar_Profissional.ForeColor = SystemColors.ControlText;
		Btn_Pesquisar_Profissional.Image = (Image)resources.GetObject("Btn_Pesquisar_Profissional.Image");
		Btn_Pesquisar_Profissional.Location = new Point(742, 12);
		Btn_Pesquisar_Profissional.Name = "Btn_Pesquisar_Profissional";
		Btn_Pesquisar_Profissional.Size = new Size(35, 33);
		Btn_Pesquisar_Profissional.TabIndex = 8;
		Btn_Pesquisar_Profissional.UseVisualStyleBackColor = true;
		Btn_Pesquisar_Profissional.Click += Btn_Pesquisar_Profissional_Click;
		// 
		// FormularioConsultas
		// 
		AutoScaleDimensions = new SizeF(7F, 15F);
		AutoScaleMode = AutoScaleMode.Font;
		BackColor = Color.DarkSeaGreen;
		ClientSize = new Size(806, 743);
		Controls.Add(Btn_Cadastrar);
		Controls.Add(groupBox5);
		Controls.Add(label7);
		Controls.Add(groupBox4);
		Controls.Add(groupBox2);
		Controls.Add(groupBox3);
		Controls.Add(groupBox1);
		Name = "FormularioConsultas";
		StartPosition = FormStartPosition.CenterScreen;
		Text = "FormularioConsultas";
		groupBox1.ResumeLayout(false);
		groupBox1.PerformLayout();
		groupBox2.ResumeLayout(false);
		groupBox2.PerformLayout();
		groupBox3.ResumeLayout(false);
		groupBox3.PerformLayout();
		groupBox4.ResumeLayout(false);
		groupBox5.ResumeLayout(false);
		groupBox5.PerformLayout();
		ResumeLayout(false);
		PerformLayout();
	}

	#endregion

	private GroupBox groupBox1;
	private MaskedTextBox txt_CPF;
	private Label label3;
	private Label label2;
	private TextBox txt_Nome;
	private Label label1;
	private GroupBox groupBox2;
	private GroupBox groupBox3;
	private GroupBox groupBox4;
	private MaskedTextBox txt_Celular;
	private TextBox txt_Servico;
	private Label label4;
	private Label label7;
	private TextBox txt_Nome_Profissional;
	private Label label8;
	private TextBox txt_Especialidade;
	private Label label9;
	private ComboBox comboBox_Horarios_Consultas;
	private MonthCalendar monthCalendar_Data_Consultas;
	private GroupBox groupBox5;
	private ComboBox comboBox_Formas_Pagamento;
	private TextBox txt_Valor;
	private Label label10;
	private Label label11;
	private Button Btn_Cadastrar;
	private TextBox txt_Desconto;
	private Label label6;
	private Button button1;
	private Button Btn_Pesquisar_Profissional;
}