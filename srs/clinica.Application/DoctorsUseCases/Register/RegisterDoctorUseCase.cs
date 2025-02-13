using AutoMapper;
using clinica.Communication.Doctors.Requests;
using clinica.Communication.Doctors.Responses;
using clinica.Domain.Entities;
using clinica.Domain.Repositories.Doutores;

namespace clinica.Application.Doctors.Register;
internal class RegisterDoctorUseCase : IRegisterDoctorUseCase
{
	private readonly IMapper _mapper;
	private readonly IWriteOnlyDoctorsRepository _repository;

	public RegisterDoctorUseCase(IMapper mapper, IWriteOnlyDoctorsRepository repository)
	{
		_mapper = mapper;
		_repository = repository;
	}

	public async Task<ResponseRegisteredDoctorJson> ExecuteAsync(RequestRegisterDoctorJson request)
	{
		Validate(request);

		var doctor = _mapper.Map<Doctor>(request);

		await _repository.AddAsync(doctor);

		return _mapper.Map<ResponseRegisteredDoctorJson>(doctor);
	}
	private static void Validate(RequestRegisterDoctorJson request)
	{
		var result = new DoctorsValidator().Validate(request);

		if (result.IsValid == false)
		{
			throw new Exception("Dados inválidos!");
		}
	}
}
