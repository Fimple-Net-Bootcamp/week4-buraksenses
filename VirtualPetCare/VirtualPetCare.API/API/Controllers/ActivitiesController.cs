using AutoMapper;
using FluentValidation;
using Microsoft.AspNetCore.Mvc;
using VirtualPetCare.API.API.Controllers.Core;
using VirtualPetCare.API.Application.DTOs.Activity;
using VirtualPetCare.API.Application.Interfaces;
using VirtualPetCare.API.Application.Validators.Activity;
using VirtualPetCare.API.Data.Entity;

namespace VirtualPetCare.API.API.Controllers;

[Route("api/v1/activities")]
public class ActivitiesController : BaseApiController
{
    private readonly IActivityService _activityService;

    public ActivitiesController(IActivityService activityService)
    {
        _activityService = activityService;
    }
    
    //GET ACTIVITIES
    [HttpGet]
    [Route("{id:guid}")]
    public async Task<IActionResult> GetActivitiesById(Guid id)
    {
        var activities = await _activityService.GetPetActivitiesAsync(id);
        
        return Ok(activities);
    }

    [HttpPost]
    public async Task<IActionResult> CreateActivity([FromBody] CreateActivityRequestDto requestDto)
    {
        try
        {
            var validator = new CreateActivityValidator();
            await validator.ValidateAndThrowAsync(requestDto);
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
        
        await _activityService.CreateAsync(requestDto);

        return Ok(requestDto);
    }
}