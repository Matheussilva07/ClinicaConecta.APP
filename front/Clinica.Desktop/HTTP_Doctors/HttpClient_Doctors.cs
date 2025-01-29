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
		const string route = "/doutores";

		var client = GetClient();

		HttpResponseMessage httpResponse = await client.PostAsJsonAsync(requestUri: route, value: request);

		return httpResponse.IsSuccessStatusCode;
	}
	public static async Task<List<ResponseDoctor>?> DoGetAll()
	{
		var client = GetClient();

		const string ROUTE = "/doutores";

		HttpResponseMessage httpResponse =	await client.GetAsync(ROUTE);

		var response = await  httpResponse.Content.ReadAsStringAsync();

		return JsonConvert.DeserializeObject<List<ResponseDoctor>>(response);
	}


}
