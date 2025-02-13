using AutoMapper;
using clinica.Communication.Doctors.Responses;
using clinica.Domain.Repositories.Doutores;

namespace clinica.Application.Doctors.GetByName;
internal class GetDoctorByNameUseCase : IGetDoctorByNameUseCase
{
	private readonly IMapper _mapper;
	private readonly IReadOnlyDoctorsRepository _repository;

	public GetDoctorByNameUseCase(IMapper mapper, IReadOnlyDoctorsRepository repository)
	{
		_mapper = mapper;
		_repository = repository;
	}

	public async Task<ResponseDoctorsJson?> ExecuteAsync(string name)
	{
		var doctor = await _repository.GetByName(name) ?? throw new ArgumentException("Cadastro não encontrado!");

		return _mapper.Map<ResponseDoctorsJson>(doctor);
	}
}
