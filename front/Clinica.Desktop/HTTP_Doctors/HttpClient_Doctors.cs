using Clinica.Desktop.Communication.Doctors.Requests;
using Clinica.Desktop.Communication.Doctors.Responses;
using Newtonsoft.Json;
using System.Net.Http.Json;

namespace Clinica.Desktop.HTTP_Doctors;
internal class HttpClient_Doctors
{
	private static HttpClient GetClient()
	{
		var client = new HttpClient()
		{
			BaseAddress = new Uri("http://localhost:5054/")
		};

		return client;
	}

	public static async Task<bool> DoPost(RequestRegisterDoctorJson request)
	{
		try
		{
			const string route = "/doutores";

			var client = GetClient();

			HttpResponseMessage httpResponse = await client.PostAsJsonAsync(requestUri: route, value: request);

			return httpResponse.IsSuccessStatusCode;
		}
		catch
		{
			MessageBox.Show("Erro na requisição");
			return false;
		}
	}

	public static async Task<List<ResponseDoctor>?> DoGetAll()
	{
		var client = GetClient();

		const string ROUTE = "/doutores";

		HttpResponseMessage httpResponse = await client.GetAsync(ROUTE);

		var response = await httpResponse.Content.ReadAsStringAsync();

		return JsonConvert.DeserializeObject<List<ResponseDoctor>>(response);
	}

	public static async Task<ResponseDoctor?> DoGetByName(string name)
	{
		try
		{
			string ROUTE = "/doutores";

			var client = GetClient();

			HttpResponseMessage httpResponse = await client.GetAsync($"{ROUTE}/{name}");

			var response = await httpResponse.Content.ReadAsStringAsync();

			return JsonConvert.DeserializeObject<ResponseDoctor>(response);
		}
		catch
		{
			MessageBox.Show("Erro na requisição");
			return null;
		}
	}

	public static async Task<bool> DoPut(RequestUpdateDoctorJson request, string id)
	{
		try
		{
			var client = GetClient();

			string ROUTE = $"/doutores/{id}";

			HttpResponseMessage httpResponse = await client.PutAsJsonAsync(ROUTE, request);

			return httpResponse.IsSuccessStatusCode;
		}
		catch
		{
			MessageBox.Show("Erro ao fazer a requisição");
			return false;
		}
	}

	public static async Task<bool> DoDelete(string id)
	{
		try
		{
			var client = GetClient();

			string ROUTE = $"/doutores/{id}";

			HttpResponseMessage httpResponse = await client.DeleteAsync(ROUTE);

			return httpResponse.IsSuccessStatusCode;
		}
		catch
		{
			MessageBox.Show("Erro na requisição");
			return false;
		}
	}
}
