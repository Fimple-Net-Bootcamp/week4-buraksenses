using AutoMapper;
using VirtualPetCare.API.Application.DTOs.Activity;
using VirtualPetCare.API.Application.DTOs.HealthStatus;
using VirtualPetCare.API.Application.DTOs.Nutrition;
using VirtualPetCare.API.Application.DTOs.Pet;
using VirtualPetCare.API.Application.DTOs.User;
using VirtualPetCare.API.Application.Interfaces;
using VirtualPetCare.API.Domain.Entities;
using VirtualPetCare.API.Domain.Interfaces;

namespace VirtualPetCare.API.Application.Services;

public class UserService : IUserService
{
    private readonly IUserRepository _repository;
    private readonly IMapper _mapper;

    public UserService(IUserRepository repository, IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
    }
    
    public async Task<RetrieveUserRequestDto?> GetByIdAsync(Guid id)
    {
        var user = await _repository.GetByIdAsync(id);

        return _mapper.Map<RetrieveUserRequestDto>(user);
    }

    public async Task<List<RetrievePetStatisticsDto>?> GetPetStatisticsByIdAsync(Guid id)
    {
        var statistics = await _repository.GetPetStatisticsByIdAsync(id);

        var petStatisticsDtoList = statistics?.Select(statistic => new RetrievePetStatisticsDto
        {
            Activities = _mapper.Map<List<RetrieveActivityRequestDto>>(statistic.Activities), 
            HealthStatus = _mapper.Map<RetrieveHealthStatusRequestDto>(statistic.HealthStatus), 
            Nutritions = _mapper.Map<List<RetrieveNutritionRequestDto>>(statistic.Nutritions)
        }).ToList();

        return petStatisticsDtoList;
    }

    public async Task<CreateUserRequestDto> CreateAsync(CreateUserRequestDto createUserRequestDto)
    {
        var user = _mapper.Map<User>(createUserRequestDto);

        await _repository.CreateAsync(user);

        return createUserRequestDto;
    }
}