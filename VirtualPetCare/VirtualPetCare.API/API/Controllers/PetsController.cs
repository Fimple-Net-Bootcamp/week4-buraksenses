using Microsoft.AspNetCore.Mvc;
using VirtualPetCare.API.API.Controllers.Core;
using VirtualPetCare.API.Application.DTOs.Pet;
using VirtualPetCare.API.Application.Interfaces;

namespace VirtualPetCare.API.API.Controllers;

[Route("api/v1/pets")]
public class PetsController : BaseApiController
{
    private readonly IPetService _service;
    public PetsController(IPetService service)
    {
        _service = service;
    }

    [HttpGet]
    public async Task<IActionResult> GetAllAsync()
    {
        var pets = await _service.GetAllAsync();

        return Ok(pets);
    }

    [HttpGet]
    [Route("{id:guid}")]
    public async Task<IActionResult> GetByIdAsync([FromRoute] Guid id)
    {
        var pet = await _service.GetByIdAsync(id);

        if (pet == null)
            return NotFound();

        return Ok(pet);
    }

    [HttpPost]
    public async Task<IActionResult> CreateAsync([FromBody] CreatePetRequestDto requestDto)
    {
        await _service.CreateAsync(requestDto);

        return Ok(requestDto);
    }

    [HttpPut]
    [Route("{id:guid}")]
    public async Task<IActionResult> UpdateAsync([FromRoute] Guid id, [FromBody] UpdatePetRequestDto requestDto)
    {
        var petDto = await _service.UpdateAsync(id, requestDto);

        if (petDto == null)
            return BadRequest();

        return Accepted();
    }
}