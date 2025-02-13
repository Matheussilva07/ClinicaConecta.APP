namespace clinica.Application.DoctorsUseCases.Delete;
public interface IDeleteDoctorUseCase
{
	Task ExecuteAsync(string id);
}
