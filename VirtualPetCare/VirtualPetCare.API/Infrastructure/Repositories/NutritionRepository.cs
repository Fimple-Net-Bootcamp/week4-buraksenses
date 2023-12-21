using Microsoft.EntityFrameworkCore;
using VirtualPetCare.API.Data.Entity;
using VirtualPetCare.API.Domain.Interfaces;
using VirtualPetCare.API.Persistence;

namespace VirtualPetCare.API.Infrastructure.Repositories;

public class NutritionRepository : INutritionRepository
{
    private readonly VirtualPetCareDbContext _dbContext;

    public NutritionRepository(VirtualPetCareDbContext dbContext)
    {
        _dbContext = dbContext;
    }
    
    public async Task<List<Nutrition>> GetAllAsync()
    {
        return await _dbContext.Nutritions.ToListAsync();
    }

    public async Task<Nutrition> CreateAsync(Nutrition nutrition)
    {
        await _dbContext.Nutritions.AddAsync(nutrition);
        await _dbContext.SaveChangesAsync();
        return nutrition;
    }
}