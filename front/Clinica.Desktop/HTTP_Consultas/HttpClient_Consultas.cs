using Clinica.Desktop.Communication.Consultas.Requests;
using System.Net.Http.Json;

namespace Clinica.Desktop.HTTP_Consultas;
internal class HttpClient_Consultas
{
	private static HttpClient GetClient()
	{
		var client = new HttpClient();
		client.BaseAddress = new Uri("http://localhost:5054");

		return client;
	}

	public async static Task<bool> DoPost(RequestRegisterConsultaJson request)
	{
		const string ROUTE = "/consultas";

		var client = GetClient();

		HttpResponseMessage httpResponse = await client.PostAsJsonAsync(ROUTE, request);

		return httpResponse.IsSuccessStatusCode;
	} 
}
