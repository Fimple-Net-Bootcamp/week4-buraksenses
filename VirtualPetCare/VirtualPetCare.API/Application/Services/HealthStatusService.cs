using AutoMapper;
using VirtualPetCare.API.Application.DTOs.HealthStatus;
using VirtualPetCare.API.Application.Interfaces;
using VirtualPetCare.API.Domain.Entities;
using VirtualPetCare.API.Domain.Interfaces;

namespace VirtualPetCare.API.Application.Services;

public class HealthStatusService : IHealthStatusService
{
    private readonly IHealthStatusRepository _healthRepository;
    private readonly IMapper _mapper;

    public HealthStatusService(IHealthStatusRepository repository, IMapper mapper)
    {
        _healthRepository = repository;
        _mapper = mapper;
    }
    
    public async Task<RetrieveHealthStatusRequestDto> GetById(Guid petId)
    {
        var healthStatus = await _healthRepository.GetByIdAsync(petId);

        var healthStatusDto = _mapper.Map<RetrieveHealthStatusRequestDto>(healthStatus);

        return healthStatusDto;
    }

    public async Task<UpdateHealthStatusRequestDto?> Update(Guid id, UpdateHealthStatusRequestDto requestDto)
    {
        var healthStatus = await _healthRepository.GetByIdAsync(id);

        if (healthStatus == null)
            return null;

        healthStatus = _mapper.Map<HealthStatus>(requestDto);

        await _healthRepository.UpdateAsync(id, healthStatus);

        return requestDto;
    }
}