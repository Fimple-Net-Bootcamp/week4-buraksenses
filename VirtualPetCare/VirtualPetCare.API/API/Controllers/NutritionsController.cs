using Microsoft.AspNetCore.Mvc;
using VirtualPetCare.API.API.Controllers.Core;
using VirtualPetCare.API.Application.DTOs.PetNutrition;
using VirtualPetCare.API.Application.Interfaces;

namespace VirtualPetCare.API.API.Controllers;

[Route("api/v1/nutritions")]
public class NutritionsController : BaseApiController
{
   private readonly INutritionService _service;

   public NutritionsController(INutritionService service)
   {
      _service = service;
   }
   
   [HttpGet]
   public async Task<IActionResult> GetAllAsync()
   {
      var nutritions = await _service.GetAllAsync();

      return Ok(nutritions);
   }

   [HttpPost]
   [Route("{petId:guid}")]
   public async Task<IActionResult> CreatePetNutritionAsync([FromRoute] Guid petId, [FromBody] CreatePetNutritionRequestDto requestDto)
   {
      var petNutrition = await _service.CreatePetNutritionAsync(petId, requestDto);

      return Ok(petNutrition);
   }
}