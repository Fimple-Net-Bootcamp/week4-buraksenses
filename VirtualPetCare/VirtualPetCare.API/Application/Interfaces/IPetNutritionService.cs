using VirtualPetCare.API.Application.DTOs.PetNutrition;

namespace VirtualPetCare.API.Application.Interfaces;

public interface IPetNutritionService
{
    Task<CreatePetNutritionRequestDto> CreateAsync(CreatePetNutritionRequestDto requestDto);
}