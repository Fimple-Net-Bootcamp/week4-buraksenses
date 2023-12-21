using VirtualPetCare.API.Application.DTOs.User;
using VirtualPetCare.API.Data.Entity;
using VirtualPetCare.API.Domain.Entities;

namespace VirtualPetCare.API.Domain.Interfaces;

public interface IUserRepository
{
    Task<User?> GetByIdAsync(Guid id);

    Task<User> CreateAsync(User user);
}