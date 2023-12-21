using VirtualPetCare.API.Application.DTOs.HealthStatus;

namespace VirtualPetCare.API.Application.Interfaces;

public interface IHealthStatusService
{
    Task<RetrieveHealthStatusRequestDto> GetById(Guid petId);

    Task<UpdateHealthStatusRequestDto?> Update(Guid id, UpdateHealthStatusRequestDto requestDto);
}