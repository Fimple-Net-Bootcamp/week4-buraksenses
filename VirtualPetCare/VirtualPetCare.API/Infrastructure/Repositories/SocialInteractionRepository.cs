using Microsoft.EntityFrameworkCore;
using VirtualPetCare.API.Domain.Entities;
using VirtualPetCare.API.Domain.Interfaces;
using VirtualPetCare.API.Persistence;

namespace VirtualPetCare.API.Infrastructure.Repositories;

public class SocialInteractionRepository : ISocialInteractionRepository
{
    private readonly VirtualPetCareDbContext _dbContext;

    public SocialInteractionRepository(VirtualPetCareDbContext dbContext)
    {
        _dbContext = dbContext;
    }
    
    public async Task<List<SocialInteraction>?> GetSocialInteractionsByPetIdAsync(Guid petId)
    {
        var pet = await _dbContext.Pets.Include(p => p.SocialInteractions).SingleOrDefaultAsync(p => p.Id == petId);

        return pet?.SocialInteractions.ToList();
    }

    public async Task<SocialInteraction?> CreateSocialInteraction(SocialInteraction socialInteraction,List<Guid> petIds)
    {
        var existingPetIds = await _dbContext.Pets
            .Where(p => petIds.Contains(p.Id))
            .Select(p => p.Id)
            .ToListAsync();

        if (!existingPetIds.Any())
            return null;

        foreach (var petId in existingPetIds)
        {
            var petSocialInteraction = new PetSocialInteraction
            {
                PetId = petId,
                SocialInteractionId = socialInteraction.Id
            };

            _dbContext.Set<PetSocialInteraction>().Add(petSocialInteraction);
        }

        await _dbContext.SaveChangesAsync();

        return socialInteraction;
    }
}