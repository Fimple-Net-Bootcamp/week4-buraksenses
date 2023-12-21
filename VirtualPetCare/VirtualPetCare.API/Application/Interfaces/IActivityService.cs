using VirtualPetCare.API.Application.DTOs.Activity;

namespace VirtualPetCare.API.Application.Interfaces;

public interface IActivityService
{
    Task<List<RetrieveActivityRequestDto>?> GetPetActivitiesAsync(Guid id);

    Task<CreateActivityRequestDto> CreateAsync(CreateActivityRequestDto requestDto);
}