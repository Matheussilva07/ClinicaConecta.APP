using AutoMapper;
using clinica.Communication.Doctors.Responses;
using clinica.Domain.Repositories.Doutores;

namespace clinica.Application.Doctors.GetAll;
internal class GetAllDoctorsUseCase : IGetAllDoctorsUseCase
{
	private readonly IMapper _mapper;
	private readonly IReadOnlyDoctorsRepository _repository;

	public GetAllDoctorsUseCase(IMapper mapper, IReadOnlyDoctorsRepository repository)
	{
		_mapper = mapper;
		_repository = repository;
	}

	public async Task<List<ResponseDoctorsJson>> ExecuteAsync()
	{
		var doctors = await _repository.GetAllAsync();

		return _mapper.Map<List<ResponseDoctorsJson>>(doctors);
	}
}
