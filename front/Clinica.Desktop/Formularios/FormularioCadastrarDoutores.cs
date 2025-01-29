using Clinica.Desktop.Communication.Doctors.Enums;
using Clinica.Desktop.Communication.Doctors.Requests;
using Clinica.Desktop.HTTP_Doctors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clinica.Desktop.Formularios;
public partial class FormularioCadastrarDoutores : Form
{
	public FormularioCadastrarDoutores()
	{
		InitializeComponent();
	}

	private async void Btn_Cadastrar_Click(object sender, EventArgs e)
	{
		Expiration vencimento = comboBox_Vencimento.Text switch
		{
			"Vigente" => Expiration.current,
			"Vencido" => Expiration.expire,
			_ => throw new NotImplementedException(),
		};


		var request = new RequestRegisterDoctorJson
		{
			Name = Txt_Name.Text,
			Email = Txt_Email.Text,
			Cpf = Txt_CPF.Text,
			Rg = Txt_RG.Text,
			Address = Txt_Address.Text,
			Telephone = Txt_Telephone.Text,
			Expertise = Txt_Especialidade.Text,
			Date_Hire = Txt_Date_Hire.Value,
			Date_Fire = Txt_Date_Fire.Value,
			Value = Convert.ToDecimal(Txt_Valor.Text),
			Expiration = vencimento,
			Sessions = Convert.ToInt32(Txt_Sessoes.Text),
			Work_hours = Convert.ToInt32(Txt_WorkHours.Text),
			Turns = Txt_Turnos.Text,
			BankAccount = Txt_Account.Text,
		};



		await HttpClient_Doctors.DoPost();
	}
}
