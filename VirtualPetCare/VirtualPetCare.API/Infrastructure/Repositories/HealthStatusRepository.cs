using Microsoft.EntityFrameworkCore;
using VirtualPetCare.API.Data.Entity;
using VirtualPetCare.API.Domain.Entities;
using VirtualPetCare.API.Domain.Interfaces;
using VirtualPetCare.API.Persistence;

namespace VirtualPetCare.API.Infrastructure.Repositories;

public class HealthStatusRepository : IHealthStatusRepository
{
    private readonly VirtualPetCareDbContext _dbContext;

    public HealthStatusRepository(VirtualPetCareDbContext dbContext)
    {
        _dbContext = dbContext;
    }
    
    public async Task<HealthStatus?> GetByIdAsync(Guid petId)
    {
        return await _dbContext.HealthStatusList.FirstOrDefaultAsync(x => x.PetId == petId);
    }

    public async Task<HealthStatus?> UpdateAsync(Guid petId, HealthStatus healthStatus)
    {
        var updatingStatus = await _dbContext.HealthStatusList.FirstOrDefaultAsync(x => x.PetId == petId);

        if (updatingStatus == null)
            return null;
        
        updatingStatus.VaccinationStatus = healthStatus.VaccinationStatus;
        updatingStatus.Notes = healthStatus.Notes;
        updatingStatus.CheckupDate = healthStatus.CheckupDate;

        _dbContext.HealthStatusList.Update(updatingStatus);
        await _dbContext.SaveChangesAsync();

        return updatingStatus;
    }
}