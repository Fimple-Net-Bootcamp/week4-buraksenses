using Microsoft.AspNetCore.Mvc;
using VirtualPetCare.API.API.Controllers.Core;
using VirtualPetCare.API.Application.DTOs.Training;
using VirtualPetCare.API.Application.Interfaces;

namespace VirtualPetCare.API.API.Controllers;

[Route("api/v2/trainings")]
public class TrainingsController : BaseApiController
{
    private readonly ITrainingService _service;

    public TrainingsController(ITrainingService service)
    {
        _service = service;
    }

    [HttpGet]
    [Route("{id:guid}")]
    public async Task<IActionResult> GetTrainingsByPetIdAsync(Guid id)
    {
        var trainings = await _service.GetTrainingsByPetIdAsync(id);

        if (trainings == null)
            return NotFound();

        return Ok(trainings);
    }

    [HttpPost]
    public async Task<IActionResult> CreateTrainingForPetAsync(CreateTrainingForPetRequestDto requestDto)
    {
        await _service.CreateAsync(requestDto);

        return Ok(requestDto);
    }
}