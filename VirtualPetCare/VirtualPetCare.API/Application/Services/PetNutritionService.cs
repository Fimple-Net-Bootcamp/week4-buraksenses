using AutoMapper;
using VirtualPetCare.API.Application.DTOs.PetNutrition;
using VirtualPetCare.API.Application.Interfaces;
using VirtualPetCare.API.Domain.Entities;
using VirtualPetCare.API.Domain.Interfaces;

namespace VirtualPetCare.API.Application.Services;

public class PetNutritionService : IPetNutritionService
{
    private readonly IPetNutritionRepository _repository;
    private readonly IMapper _mapper;

    public PetNutritionService(IPetNutritionRepository repository, IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
    }
    
    public async Task<CreatePetNutritionRequestDto> CreateAsync(CreatePetNutritionRequestDto requestDto)
    {
        var petNutrition = _mapper.Map<PetNutrition>(requestDto);

        await _repository.CreateAsync(petNutrition);

        return requestDto;
    }
}