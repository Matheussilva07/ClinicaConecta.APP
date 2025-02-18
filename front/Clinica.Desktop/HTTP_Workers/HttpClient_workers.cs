using Clinica.Desktop.Communication.Funcionarios.Requests;
using Clinica.Desktop.Communication.Funcionarios.Responses;
using Newtonsoft.Json;
using System.Net.Http.Json;

namespace Clinica.Desktop.HTTP_Funcionarios;
internal class HttpClient_workers
{
	private static HttpClient GetClient()
	{
		var client = new HttpClient
		{
			BaseAddress = new Uri("https://localhost:7147/")
		};

		return client;
	}

	public static async Task<bool> DoPost(RequestRegisterFuncionarioJson request)
	{
		const string ROUTE = "funcionarios/";

		var client = GetClient();

		HttpResponseMessage httpResponse = await client.PostAsJsonAsync(ROUTE, request);

		return httpResponse.IsSuccessStatusCode;
	}

	public static async Task<List<ResponseWorkerJson>> DoGetAll()
	{
		const string ROUTE = "funcionarios/";

		var client = GetClient();

		HttpResponseMessage httpResponse = client.GetAsync(ROUTE).GetAwaiter().GetResult();

		var response = await httpResponse.Content.ReadAsStringAsync();

		return JsonConvert.DeserializeObject<List<ResponseWorkerJson>>(response)!;
	}

	public static async Task<ResponseWorkerJson?> DoGetByName(string name)
	{
		try
		{
			string route = $"funcionarios/{name}";

			var client = GetClient();

			HttpResponseMessage httpResponse = await client.GetAsync(route);

			var response = await httpResponse.Content.ReadAsStringAsync();

			return JsonConvert.DeserializeObject<ResponseWorkerJson>(response);
		}
		catch
		{
			MessageBox.Show("Funcionário não encontrado!");
			return null;
		}

	}

	public static async Task<bool> DoUpdate(string id, RequestUpdateFuncionarioJson request)
	{
		string ROUTE = $"funcionarios/{id}";

		var client = GetClient();

		HttpResponseMessage httpResponse = await client.PutAsJsonAsync(ROUTE,request);

		return httpResponse.IsSuccessStatusCode;
	}

	public static async Task<bool> DoDelete(string id)
	{
		var client = GetClient();

		string ROUTE = $"funcionarios/{id}";

		HttpResponseMessage httpResponse = await client.DeleteAsync(ROUTE);

		return httpResponse.IsSuccessStatusCode;
	}
}
