using clinica.Communication.Doctors.Requests;

namespace clinica.Application.Doctors.Update;
public interface IUpdateDoctorUseCase
{
	Task ExecuteAsync(RequestUpdateDoctorJson request, string id);
}
