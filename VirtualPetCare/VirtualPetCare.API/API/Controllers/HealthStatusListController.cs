using Microsoft.AspNetCore.Mvc;
using VirtualPetCare.API.API.Controllers.Core;
using VirtualPetCare.API.Application.DTOs.HealthStatus;
using VirtualPetCare.API.Application.Interfaces;

namespace VirtualPetCare.API.API.Controllers;

[Route("api/v1/healthstatuslist")]
public class HealthStatusListController : BaseApiController
{
    private readonly IHealthStatusService _service;

    public HealthStatusListController(IHealthStatusService service)
    {
        _service = service;
    }
    
    [HttpGet]
    [Route("{petId:guid}")]
    public async Task<IActionResult> GetHealthStatusByPetId([FromRoute] Guid petId)
    {
        var healthStatusRequestDto = await _service.GetById(petId);

        return Ok(healthStatusRequestDto);
    }

    [HttpPatch]
    [Route("{petId:guid}")]
    public async Task<IActionResult> UpdateHealthStatusByPetId([FromRoute] Guid petId,
        [FromBody] UpdateHealthStatusRequestDto requestDto)
    {
        var updatedHealthStatus = await _service.Update(petId, requestDto);

        if (updatedHealthStatus == null)
            return NotFound();

        return Ok(updatedHealthStatus);
    }
}