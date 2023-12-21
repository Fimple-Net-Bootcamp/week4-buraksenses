using VirtualPetCare.API.Application.DTOs.Nutrition;
using VirtualPetCare.API.Data.Entity;

namespace VirtualPetCare.API.Domain.Interfaces;

public interface INutritionRepository
{
    Task<List<Nutrition>> GetAllAsync();

    Task<Nutrition> CreateAsync(Nutrition nutrition);
}