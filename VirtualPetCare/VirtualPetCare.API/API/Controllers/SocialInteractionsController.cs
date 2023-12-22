using Microsoft.AspNetCore.Mvc;
using VirtualPetCare.API.API.Controllers.Core;
using VirtualPetCare.API.Application.DTOs.SocialInteraction;
using VirtualPetCare.API.Application.Interfaces;

namespace VirtualPetCare.API.API.Controllers;

[Route("api/v2/socialinteractions")]
public class SocialInteractionsController : BaseApiController
{
    private readonly ISocialInteractionService _service;

    public SocialInteractionsController(ISocialInteractionService service)
    {
        _service = service;
    }

    [HttpGet]
    [Route("{petId:guid}")]
    public async Task<IActionResult> GetSocialInteractionsByPetIdAsync([FromRoute] Guid petId)
    {
        var socialInteractions = await _service.RetrieveSocialInteractionsByPetId(petId);

        if (socialInteractions == null)
            return NotFound();
        if (!socialInteractions.Any())
            return NoContent();

        return Ok(socialInteractions);
    }

    [HttpPost]
    public async Task<IActionResult> CreateSocialInteractionAsync(
        [FromBody] CreateSocialInteractionRequestDto requestDto)
    {
        await _service.CreateSocialInteractionAsync(requestDto);

        return Ok();
    }
}