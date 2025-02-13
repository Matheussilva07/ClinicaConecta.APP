using clinica.Domain.Repositories.Doutores;

namespace clinica.Application.DoctorsUseCases.Delete;
internal class DeleteDoctorUseCase : IDeleteDoctorUseCase
{
	private readonly IWriteOnlyDoctorsRepository _repository;

	public DeleteDoctorUseCase(IWriteOnlyDoctorsRepository repository)
	{
		_repository = repository;
	}

	public async Task ExecuteAsync(string id)
	{
		if (id is null)
		{
			throw new ArgumentException("Id vazio!");
		}

		await _repository.DeleteAsync(id);
	}
}
