using AutoMapper;
using VirtualPetCare.API.Application.DTOs.Pet;
using VirtualPetCare.API.Application.Interfaces;
using VirtualPetCare.API.Data.Entity;
using VirtualPetCare.API.Domain.Interfaces;

namespace VirtualPetCare.API.Application.Services;

public class PetService : IPetService
{
    private readonly IPetRepository _repository;
    private readonly IMapper _mapper;

    public PetService(IPetRepository repository, IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
    }
    
    public async Task<List<RetrievePetRequestDto>> GetAllAsync()
    {
        var pets = await _repository.GetAllAsync();

        var petDto = _mapper.Map<List<RetrievePetRequestDto>>(pets);

        return petDto;
    }

    public async Task<RetrievePetRequestDto?> GetByIdAsync(Guid id)
    {
        var pet = await _repository.GetByIdAsync(id);

        return _mapper.Map<RetrievePetRequestDto>(pet);
    }

    public async Task<CreatePetRequestDto> CreateAsync(CreatePetRequestDto requestDto)
    {
        var pet = _mapper.Map<Pet>(requestDto);

        await _repository.CreateAsync(pet);

        return requestDto;
    }

    public async Task<UpdatePetRequestDto?> UpdateAsync(Guid id,UpdatePetRequestDto requestDto)
    {
        var pet = await _repository.GetByIdAsync(id);

        if (pet == null)
            return null;

        pet = _mapper.Map<Pet>(requestDto);
        
        await _repository.UpdateAsync(id, pet);

        return requestDto;
    }
}