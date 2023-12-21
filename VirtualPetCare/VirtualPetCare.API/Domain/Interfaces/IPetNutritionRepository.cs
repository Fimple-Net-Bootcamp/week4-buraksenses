using VirtualPetCare.API.Domain.Entities;

namespace VirtualPetCare.API.Domain.Interfaces;

public interface IPetNutritionRepository
{
    Task<PetNutrition> CreateAsync(PetNutrition petNutrition);
}