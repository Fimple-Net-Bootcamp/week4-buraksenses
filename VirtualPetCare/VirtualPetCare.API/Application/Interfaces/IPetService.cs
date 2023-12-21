using VirtualPetCare.API.Application.DTOs.Pet;

namespace VirtualPetCare.API.Application.Interfaces;

public interface IPetService
{
    Task<List<RetrievePetRequestDto>> GetAllAsync();
    Task<RetrievePetRequestDto?> GetByIdAsync(Guid id);
    Task<CreatePetRequestDto> CreateAsync(CreatePetRequestDto requestDto);
    Task<UpdatePetRequestDto?> UpdateAsync(Guid id, UpdatePetRequestDto requestDto);
}