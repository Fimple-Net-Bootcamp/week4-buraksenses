using VirtualPetCare.API.Application.DTOs.Nutrition;
using VirtualPetCare.API.Application.DTOs.PetNutrition;

namespace VirtualPetCare.API.Application.Interfaces;

public interface INutritionService
{
    Task<List<RetrieveNutritionRequestDto>> GetAllAsync();

    Task<CreatePetNutritionRequestDto> CreatePetNutritionAsync(Guid petId, CreatePetNutritionRequestDto requestDto);
}