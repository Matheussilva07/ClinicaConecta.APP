using clinica.Communication.Doctors.Responses;

namespace clinica.Application.Doctors.GetAll;
public interface IGetAllDoctorsUseCase
{
	Task<List<ResponseDoctorsJson>> ExecuteAsync();
}
