using AutoMapper;
using VirtualPetCare.API.Application.DTOs.Training;
using VirtualPetCare.API.Application.Interfaces;
using VirtualPetCare.API.Domain.Entities;
using VirtualPetCare.API.Domain.Interfaces;

namespace VirtualPetCare.API.Application.Services;

public class TrainingService : ITrainingService
{
    private readonly ITrainingRepository _repository;
    private readonly IMapper _mapper;

    public TrainingService(ITrainingRepository repository,IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
    }
    
    public async Task<CreateTrainingForPetRequestDto> CreateAsync(CreateTrainingForPetRequestDto requestDto)
    {
        var training = _mapper.Map<Training>(requestDto);

        await _repository.CreateAsync(training);

        return requestDto;
    }

    public async Task<List<RetrieveTrainingsByPetIdRequestDto>?> GetTrainingsByPetIdAsync(Guid id)
    {
        var trainings = await _repository.GetTrainingsByPetIdAsync(id);

        if (trainings == null)
            return null;

        var trainingsDto = _mapper.Map<List<RetrieveTrainingsByPetIdRequestDto>>(trainings);

        return trainingsDto;
    }
}