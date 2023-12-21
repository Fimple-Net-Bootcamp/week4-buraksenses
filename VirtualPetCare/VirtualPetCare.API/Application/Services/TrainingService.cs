using VirtualPetCare.API.Application.DTOs.Training;
using VirtualPetCare.API.Application.Interfaces;

namespace VirtualPetCare.API.Application.Services;

public class TrainingService : ITrainingService
{
    public Task<CreateTrainingForPetRequestDto> CreateAsync(CreateTrainingForPetRequestDto requestDto)
    {
        return null;
    }

    public Task<RetrieveTrainingsByPetIdRequestDto> GetTrainingsByPetIdAsync(RetrieveTrainingsByPetIdRequestDto requestDto)
    {
        return null;
    }
}