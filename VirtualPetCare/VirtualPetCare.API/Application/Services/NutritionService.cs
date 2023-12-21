using AutoMapper;
using VirtualPetCare.API.Application.DTOs.Nutrition;
using VirtualPetCare.API.Application.DTOs.PetNutrition;
using VirtualPetCare.API.Application.Interfaces;
using VirtualPetCare.API.Domain.Entities;
using VirtualPetCare.API.Domain.Interfaces;

namespace VirtualPetCare.API.Application.Services;

public class NutritionService : INutritionService
{
    private readonly IPetRepository _petRepository;
    private readonly IPetNutritionRepository _petNutritionRepository;
    private readonly INutritionRepository _nutritionRepository;
    private readonly IMapper _mapper;

    public NutritionService(IPetRepository petRepository,IPetNutritionRepository petNutritionRepository,INutritionRepository nutritionRepository, IMapper mapper)
    {
        _petRepository = petRepository;
        _petNutritionRepository = petNutritionRepository;
        _nutritionRepository = nutritionRepository;
        _mapper = mapper;
    }
    
    public async Task<List<RetrieveNutritionRequestDto>> GetAllAsync()
    {
        var nutritions = await _nutritionRepository.GetAllAsync();

        var nutritionsDto = _mapper.Map<List<RetrieveNutritionRequestDto>>(nutritions);

        return nutritionsDto;
    }

    public async Task<CreatePetNutritionRequestDto> CreatePetNutritionAsync(Guid petId, CreatePetNutritionRequestDto requestDto)
    {
        var pet = await _petRepository.GetByIdAsync(petId);

        if (pet == null)
        {
            throw new ArgumentException("Pet could not found!");
        }

        var petNutrition = _mapper.Map<PetNutrition>(requestDto);

        petNutrition.PetId = petId;

        await _petNutritionRepository.CreateAsync(petNutrition);

        return requestDto;
    }
}