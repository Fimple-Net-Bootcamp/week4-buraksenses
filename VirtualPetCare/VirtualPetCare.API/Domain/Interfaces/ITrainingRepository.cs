using VirtualPetCare.API.Domain.Entities;

namespace VirtualPetCare.API.Domain.Interfaces;

public interface ITrainingRepository
{
    Task<Training?> CreateAsync(Training training);
    
    Task<List<Training>?> GetTrainingsByPetIdAsync(Guid id);
}