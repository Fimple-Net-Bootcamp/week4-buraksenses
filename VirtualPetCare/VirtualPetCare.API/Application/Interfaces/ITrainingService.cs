using VirtualPetCare.API.Application.DTOs.Training;

namespace VirtualPetCare.API.Application.Interfaces;

public interface ITrainingService
{
    Task<CreateTrainingForPetRequestDto> CreateAsync(CreateTrainingForPetRequestDto requestDto);

    Task<RetrieveTrainingsByPetIdRequestDto> GetTrainingsByPetIdAsync(RetrieveTrainingsByPetIdRequestDto requestDto);
}