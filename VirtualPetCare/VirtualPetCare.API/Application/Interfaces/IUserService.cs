using VirtualPetCare.API.Application.DTOs.User;

namespace VirtualPetCare.API.Application.Interfaces;

public interface IUserService
{
    Task<RetrieveUserRequestDto?> GetByIdAsync(Guid id);

    Task<CreateUserRequestDto> CreateAsync(CreateUserRequestDto createUserRequestDto);
}