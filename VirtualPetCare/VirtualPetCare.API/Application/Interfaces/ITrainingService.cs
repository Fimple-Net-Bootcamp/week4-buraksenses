using VirtualPetCare.API.Application.DTOs.Training;

namespace VirtualPetCare.API.Application.Interfaces;

public interface ITrainingService
{
    Task<CreateTrainingForPetRequestDto> CreateAsync(CreateTrainingForPetRequestDto requestDto);

    Task<List<RetrieveTrainingsByPetIdRequestDto>?> GetTrainingsByPetIdAsync(Guid id);
}