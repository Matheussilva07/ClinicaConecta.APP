using clinica.Communication.Doctors.Responses;

namespace clinica.Application.Doctors.GetByName;
public interface IGetDoctorByNameUseCase
{
	Task<ResponseDoctorsJson?> ExecuteAsync(string name);
}
