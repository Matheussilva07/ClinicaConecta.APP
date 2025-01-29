using clinica.Communication.Doctors.Requests;
using clinica.Communication.Doctors.Responses;

namespace clinica.Application.Doctors.Register;
public interface IRegisterDoctorUseCase
{
	Task<ResponseRegisteredDoctorJson> ExecuteAsync(RequestRegisterDoctorJson request);
}
