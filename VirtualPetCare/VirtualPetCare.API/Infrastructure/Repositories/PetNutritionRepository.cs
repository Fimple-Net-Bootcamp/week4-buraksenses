using VirtualPetCare.API.Domain.Entities;
using VirtualPetCare.API.Domain.Interfaces;
using VirtualPetCare.API.Persistence;

namespace VirtualPetCare.API.Infrastructure.Repositories;

public class PetNutritionRepository : IPetNutritionRepository
{
    private readonly VirtualPetCareDbContext _dbContext;

    public PetNutritionRepository(VirtualPetCareDbContext dbContext)
    {
        _dbContext = dbContext;
    }
    
    public async Task<PetNutrition> CreateAsync(PetNutrition petNutrition)
    {
        await _dbContext.PetNutritions.AddAsync(petNutrition);
        await _dbContext.SaveChangesAsync();
        return petNutrition;
    }
}