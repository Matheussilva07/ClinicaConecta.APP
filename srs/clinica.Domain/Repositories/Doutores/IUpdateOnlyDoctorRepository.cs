using clinica.Domain.Entities;

namespace clinica.Domain.Repositories.Doutores;
public interface IUpdateOnlyDoctorRepository
{
	Task<bool> Update(Doctor doctor, string id);
}
