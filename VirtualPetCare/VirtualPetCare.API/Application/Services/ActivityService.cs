using AutoMapper;
using VirtualPetCare.API.Application.DTOs.Activity;
using VirtualPetCare.API.Application.Interfaces;
using VirtualPetCare.API.Data.Entity;
using VirtualPetCare.API.Domain.Interfaces;

namespace VirtualPetCare.API.Application.Services;

public class ActivityService : IActivityService
{
    private readonly IActivityRepository _repository;
    private readonly IMapper _mapper;

    public ActivityService(IActivityRepository repository, IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
    }
    
    public async Task<List<RetrieveActivityRequestDto>?> GetPetActivitiesAsync(Guid id)
    {
        var activity = await _repository.GetPetActivities(id);
        
        return _mapper.Map<List<RetrieveActivityRequestDto>>(activity);
    }

    public async Task<CreateActivityRequestDto> CreateAsync(CreateActivityRequestDto requestDto)
    {
        var activity = _mapper.Map<Activity>(requestDto);

        await _repository.CreateAsync(activity);

        return requestDto;
    }
}