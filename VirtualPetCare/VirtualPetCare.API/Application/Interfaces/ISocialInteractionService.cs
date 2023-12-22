using VirtualPetCare.API.Application.DTOs.SocialInteraction;

namespace VirtualPetCare.API.Application.Interfaces;

public interface ISocialInteractionService
{
    Task<CreateSocialInteractionRequestDto?> CreateSocialInteractionAsync(CreateSocialInteractionRequestDto requestDto);

    Task<List<RetrieveSocialInteractionForPetRequestDto>?> RetrieveSocialInteractionsByPetId(Guid id);
}