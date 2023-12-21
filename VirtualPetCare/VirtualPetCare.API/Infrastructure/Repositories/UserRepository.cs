using Microsoft.EntityFrameworkCore;
using VirtualPetCare.API.Domain.Entities;
using VirtualPetCare.API.Domain.Interfaces;
using VirtualPetCare.API.Persistence;

namespace VirtualPetCare.API.Infrastructure.Repositories;

public class UserRepository : IUserRepository
{
    private readonly VirtualPetCareDbContext _dbContext;

    public UserRepository(VirtualPetCareDbContext dbContext)
    {
        _dbContext = dbContext;
    }
    
    public async Task<User?> GetByIdAsync(Guid id)
    {
        var user = await _dbContext.Users.SingleOrDefaultAsync(x => x.Id == id);

        return user;
    }

    public async Task<List<PetStatistics>?> GetPetStatisticsByIdAsync(Guid userId)
    {
        var user = await _dbContext.Users.SingleOrDefaultAsync(x => x.Id == userId);
        if (user == null)
            return null;

        var petIds = await _dbContext.Pets.Where(x => x.UserId == userId).Select(p => p.Id).ToListAsync();
        if (!petIds.Any())
            return null;

        var activitiesTask = _dbContext.Activities.Where(a => petIds.Contains(a.PetId)).ToListAsync();
        var healthStatusesTask = _dbContext.HealthStatusList.Where(h => petIds.Contains(h.PetId)).ToListAsync();
        var nutritionsTask = _dbContext.Nutritions.Where(n => n.Pets.Any(p => petIds.Contains(p.Id))).ToListAsync();

        await Task.WhenAll(activitiesTask, healthStatusesTask, nutritionsTask);

        var petStatistics = petIds.Select(petId => new PetStatistics
        {
            Activities = activitiesTask.Result.Where(a => a.PetId == petId).ToList(),
            HealthStatus = healthStatusesTask.Result.SingleOrDefault(h => h.PetId == petId),
            Nutritions = nutritionsTask.Result.Where(n => n.Pets.Any(p => p.Id == petId)).ToList()
        }).ToList();

        return petStatistics;
    }


    public async Task<User> CreateAsync(User user)
    {
        await _dbContext.Users.AddAsync(user);
        await _dbContext.SaveChangesAsync();
        return user;
    }
}