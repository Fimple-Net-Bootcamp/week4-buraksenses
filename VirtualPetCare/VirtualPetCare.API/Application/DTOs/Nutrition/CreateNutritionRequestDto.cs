using System.ComponentModel.DataAnnotations;

namespace VirtualPetCare.API.Application.DTOs.Nutrition;

public class CreateNutritionRequestDto
{
    [Required]
    [MaxLength(30,ErrorMessage = "Name has to be a maximum of 30 characters!")]
    public string Name { get; set; }

    [Required]
    public float Calories { get; set; }

    [Required]
    public int Quantity { get; set; }
}