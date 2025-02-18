using Clinica.Desktop.Communication.Pacientes.Requests;
using Clinica.Desktop.Communication.Pacientes.Responses;
using Newtonsoft.Json;
using System.Net;
using System.Net.Http.Json;

namespace Clinica.Desktop.HTTP_Pacientes;
internal class HttpClient_Pacientes
{
	private static HttpClient GetClient()
	{
		var client = new HttpClient
		{
			BaseAddress = new Uri("https://localhost:7147/")
		};

		return client;
	}
	public async static Task<bool> DoPost(RegisterPaciente request)
	{
		try
		{
			const string METHOD = "pacientes/cadastro";

			var client = GetClient();

			HttpResponseMessage httpResponse = await client.PostAsJsonAsync(METHOD, request);

			return httpResponse.IsSuccessStatusCode;
		}
		catch (Exception)
		{
			MessageBox.Show("Erro ao estabelecer a conexão");
			return false;
		}
	}
	public async static Task<List<ResponseRegisteredPaciente>?> DoGetAll()
	{
		try
		{
			var client = GetClient();

			HttpResponseMessage httpResponse = await client.GetAsync("pacientes");

			if (httpResponse.StatusCode != HttpStatusCode.OK)
			{
				MessageBox.Show("Erro na requisição");
			}

			var response = await httpResponse.Content.ReadAsStringAsync();

			List<ResponseRegisteredPaciente> pacientes = JsonConvert.DeserializeObject<List<ResponseRegisteredPaciente>>(response);

			return pacientes;
		}
		catch
		{
			MessageBox.Show("Erro ao estabelecer a conexão");
			return [];
		}
	}
	public async static Task<bool> DoUpdate(string id,string name, string email, string phone, string cpf, string address, DateTime birth)
	{
		try
		{
			var client = GetClient();

			var request = new UpdatePaciente
			{
				Name = name,
				Email = email,
				Telephone = phone,
				CPF = cpf,
				Address = address,
				Birth = birth,
			};

			HttpResponseMessage httpResponse = await client.PutAsJsonAsync($"pacientes/{id}", request);

			return httpResponse.IsSuccessStatusCode;
		}
		catch
		{
			MessageBox.Show("Erro ao estabelecer a conexão");
			return false;
		}
	}
	public async static Task<bool> DoDelete(string id)
	{
		string METHOD = $"pacientes/{id}";

		var client = GetClient();

		HttpResponseMessage httpResponse = await client.DeleteAsync(METHOD);

		return httpResponse.IsSuccessStatusCode;
	}
	public async static Task<ResponseRegisteredPaciente?> DoGetByName(string name)
	{
		try
		{
			string METHOD = $"pacientes/{name}";

			var client = GetClient();

			HttpResponseMessage httpResponse = await client.GetAsync(METHOD);

			var response = await httpResponse.Content.ReadAsStringAsync();

			var paciente = JsonConvert.DeserializeObject<ResponseRegisteredPaciente>(response);

			return paciente;
		}
		catch
		{
			MessageBox.Show("Paciente não encontrado!");
			return null;
		}
	}
}
