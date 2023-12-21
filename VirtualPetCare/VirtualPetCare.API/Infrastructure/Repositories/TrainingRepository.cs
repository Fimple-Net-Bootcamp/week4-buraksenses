using Microsoft.EntityFrameworkCore;
using VirtualPetCare.API.Domain.Entities;
using VirtualPetCare.API.Domain.Interfaces;
using VirtualPetCare.API.Persistence;

namespace VirtualPetCare.API.Infrastructure.Repositories;

public class TrainingRepository : ITrainingRepository
{
    private readonly VirtualPetCareDbContext _dbContext;

    public TrainingRepository(VirtualPetCareDbContext dbContext)
    {
        _dbContext = dbContext;
    }
    
    public async Task<Training?> CreateAsync(Training training)
    {
        var pet = await _dbContext.Pets.SingleOrDefaultAsync(p => p.Id == training.PetId);

        if (pet == null)
            return null;
        
        pet.Trainings.Add(training);

        return training;
    }

    public async Task<List<Training>?> GetTrainingsByPetIdAsync(Guid id)
    {
        var pet = await _dbContext.Pets.SingleOrDefaultAsync(p => p.Id == id);

        return pet?.Trainings.ToList();
    }
}