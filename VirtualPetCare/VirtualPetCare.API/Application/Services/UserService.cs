using AutoMapper;
using VirtualPetCare.API.Application.DTOs.User;
using VirtualPetCare.API.Application.Interfaces;
using VirtualPetCare.API.Domain.Entities;
using VirtualPetCare.API.Domain.Interfaces;

namespace VirtualPetCare.API.Application.Services;

public class UserService : IUserService
{
    private readonly IUserRepository _repository;
    private readonly IMapper _mapper;

    public UserService(IUserRepository repository, IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
    }
    
    public async Task<RetrieveUserRequestDto?> GetByIdAsync(Guid id)
    {
        var user = await _repository.GetByIdAsync(id);

        return _mapper.Map<RetrieveUserRequestDto>(user);
    }

    public async Task<CreateUserRequestDto> CreateAsync(CreateUserRequestDto createUserRequestDto)
    {
        var user = _mapper.Map<User>(createUserRequestDto);

        await _repository.CreateAsync(user);

        return createUserRequestDto;
    }
}