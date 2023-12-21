using VirtualPetCare.API.Application.Interfaces;
using VirtualPetCare.API.Domain.Entities;
using VirtualPetCare.API.Domain.Interfaces;

namespace VirtualPetCare.API.Infrastructure.Repositories;

public class TrainingRepository : ITrainingRepository
{
    public Task<Training> CreateAsync(Training training)
    {
        return null;
    }

    public Task<List<Training>?> GetTrainingsByPetIdAsync(Guid id)
    {
        return null;
    }
}