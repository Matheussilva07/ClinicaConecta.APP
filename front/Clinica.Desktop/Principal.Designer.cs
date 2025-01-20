﻿namespace Clinica.Desktop;

partial class Principal
{
	/// <summary>
	///  Required designer variable.
	/// </summary>
	private System.ComponentModel.IContainer components = null;

	/// <summary>
	///  Clean up any resources being used.
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
	///  Required method for Designer support - do not modify
	///  the contents of this method with the code editor.
	/// </summary>
	private void InitializeComponent()
	{
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
		panel1 = new Panel();
		button6 = new Button();
		button5 = new Button();
		button4 = new Button();
		button3 = new Button();
		button2 = new Button();
		button1 = new Button();
		pictureBox1 = new PictureBox();
		panel1.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
		SuspendLayout();
		// 
		// panel1
		// 
		panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
		panel1.BackColor = Color.DarkSeaGreen;
		panel1.Controls.Add(button6);
		panel1.Controls.Add(button5);
		panel1.Controls.Add(button4);
		panel1.Controls.Add(button3);
		panel1.Controls.Add(button2);
		panel1.Controls.Add(button1);
		panel1.Location = new Point(2, 3);
		panel1.Name = "panel1";
		panel1.Size = new Size(210, 590);
		panel1.TabIndex = 0;
		// 
		// button6
		// 
		button6.BackColor = Color.DarkSeaGreen;
		button6.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
		button6.ForeColor = SystemColors.ButtonHighlight;
		button6.Location = new Point(33, 392);
		button6.Name = "button6";
		button6.Size = new Size(137, 48);
		button6.TabIndex = 5;
		button6.Text = "Relatórios";
		button6.UseVisualStyleBackColor = false;
		// 
		// button5
		// 
		button5.BackColor = Color.DarkSeaGreen;
		button5.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
		button5.ForeColor = SystemColors.ButtonHighlight;
		button5.Location = new Point(33, 322);
		button5.Name = "button5";
		button5.Size = new Size(137, 48);
		button5.TabIndex = 4;
		button5.Text = "Salas";
		button5.UseVisualStyleBackColor = false;
		// 
		// button4
		// 
		button4.BackColor = Color.DarkSeaGreen;
		button4.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
		button4.ForeColor = SystemColors.ButtonHighlight;
		button4.Location = new Point(33, 252);
		button4.Name = "button4";
		button4.Size = new Size(137, 48);
		button4.TabIndex = 3;
		button4.Text = "Consultas";
		button4.UseVisualStyleBackColor = false;
		// 
		// button3
		// 
		button3.BackColor = Color.DarkSeaGreen;
		button3.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
		button3.ForeColor = SystemColors.ButtonHighlight;
		button3.Location = new Point(33, 112);
		button3.Name = "button3";
		button3.Size = new Size(137, 48);
		button3.TabIndex = 2;
		button3.Text = "Funcionários";
		button3.UseVisualStyleBackColor = false;
		// 
		// button2
		// 
		button2.BackColor = Color.DarkSeaGreen;
		button2.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
		button2.ForeColor = SystemColors.ButtonHighlight;
		button2.Location = new Point(33, 182);
		button2.Name = "button2";
		button2.Size = new Size(137, 48);
		button2.TabIndex = 1;
		button2.Text = "Doutores";
		button2.UseVisualStyleBackColor = false;
		// 
		// button1
		// 
		button1.BackColor = Color.DarkSeaGreen;
		button1.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
		button1.ForeColor = SystemColors.ButtonHighlight;
		button1.Location = new Point(33, 42);
		button1.Name = "button1";
		button1.Size = new Size(137, 48);
		button1.TabIndex = 0;
		button1.Text = "Pacientes";
		button1.UseVisualStyleBackColor = false;
		// 
		// pictureBox1
		// 
		pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
		pictureBox1.Location = new Point(209, 3);
		pictureBox1.Name = "pictureBox1";
		pictureBox1.Size = new Size(773, 590);
		pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
		pictureBox1.TabIndex = 1;
		pictureBox1.TabStop = false;
		// 
		// Principal
		// 
		AutoScaleDimensions = new SizeF(7F, 15F);
		AutoScaleMode = AutoScaleMode.Font;
		ClientSize = new Size(983, 596);
		Controls.Add(pictureBox1);
		Controls.Add(panel1);
		Name = "Principal";
		Text = "Conecta";
		Load += Form1_Load;
		panel1.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
		ResumeLayout(false);
	}

	#endregion

	private Panel panel1;
	private PictureBox pictureBox1;
	private Button button3;
	private Button button2;
	private Button button1;
	private Button button6;
	private Button button5;
	private Button button4;
}
