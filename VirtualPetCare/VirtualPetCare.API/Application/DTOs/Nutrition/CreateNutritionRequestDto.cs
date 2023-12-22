using System.ComponentModel.DataAnnotations;

namespace VirtualPetCare.API.Application.DTOs.Nutrition;

public class CreateNutritionRequestDto
{
    public string Name { get; set; }
    
    public float Calories { get; set; }
    
    public int Quantity { get; set; }
}