using VirtualPetCare.API.Domain.Entities;

namespace VirtualPetCare.API.Domain.Interfaces;

public interface ISocialInteractionRepository
{
    Task<List<SocialInteraction>?> GetSocialInteractionsByPetIdAsync(Guid id);

    Task<SocialInteraction?> CreateSocialInteraction(SocialInteraction socialInteraction,List<Guid> petIds);
}