using AutoMapper;
using VirtualPetCare.API.Application.DTOs.SocialInteraction;
using VirtualPetCare.API.Application.Interfaces;
using VirtualPetCare.API.Domain.Entities;
using VirtualPetCare.API.Domain.Interfaces;

namespace VirtualPetCare.API.Application.Services;

public class SocialInteractionService : ISocialInteractionService
{
    private readonly ISocialInteractionRepository _repository;
    private readonly IMapper _mapper;

    public SocialInteractionService(ISocialInteractionRepository repository,IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
    }
    
    public async Task<CreateSocialInteractionRequestDto?> CreateSocialInteractionAsync(CreateSocialInteractionRequestDto requestDto)
    {
        var socialInteraction = _mapper.Map<SocialInteraction>(requestDto);

        await _repository.CreateSocialInteraction(socialInteraction, requestDto.PetIds);

        return requestDto;
    }

    public async Task<List<RetrieveSocialInteractionForPetRequestDto>?> RetrieveSocialInteractionsByPetId(Guid id)
    {
        var socialInteractions = await _repository.GetSocialInteractionsByPetIdAsync(id);

        return _mapper.Map<List<RetrieveSocialInteractionForPetRequestDto>>(socialInteractions);
    }
}