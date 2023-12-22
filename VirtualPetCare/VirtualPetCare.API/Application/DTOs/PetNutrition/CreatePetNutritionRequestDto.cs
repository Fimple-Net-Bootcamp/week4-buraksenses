using System.ComponentModel.DataAnnotations;

namespace VirtualPetCare.API.Application.DTOs.PetNutrition;

public class CreatePetNutritionRequestDto
{
    public Guid NutritionId { get; set; }
    public int Quantity { get; set; }
    public DateTime GivenDate { get; set; }
}