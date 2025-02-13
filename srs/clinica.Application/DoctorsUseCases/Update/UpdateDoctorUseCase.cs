using AutoMapper;
using clinica.Communication.Doctors.Requests;
using clinica.Domain.Entities;
using clinica.Domain.Repositories.Doutores;

namespace clinica.Application.Doctors.Update;
internal class UpdateDoctorUseCase : IUpdateDoctorUseCase
{
	private readonly IMapper _mapper;
	private readonly IUpdateOnlyDoctorRepository _repository;

	public UpdateDoctorUseCase(IMapper mapper, IUpdateOnlyDoctorRepository repository)
	{
		_mapper = mapper;
		_repository = repository;
	}

	public async Task ExecuteAsync(RequestUpdateDoctorJson request, string id)
	{
		Validate(request);

		var doctor = _mapper.Map<Doctor>(request);

		bool isSuccessful = await _repository.Update(doctor, id);

		if(isSuccessful == false)
		{
			throw new ArgumentException("Erro ao atualizar!");
		}

	}
	private static void Validate(RequestUpdateDoctorJson request)
	{
		var result = new DoctorsUpdateValidator().Validate(request);

		if(result.IsValid == false)
		{
			throw new ArgumentException("Dados inválidos");
		}
	}
}
