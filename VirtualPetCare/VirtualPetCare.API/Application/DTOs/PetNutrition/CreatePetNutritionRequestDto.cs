using System.ComponentModel.DataAnnotations;

namespace VirtualPetCare.API.Application.DTOs.PetNutrition;

public class CreatePetNutritionRequestDto
{
    [Required]
    [MaxLength(36,ErrorMessage = "A Guid should be 36 characters long!")]
    [MinLength(36,ErrorMessage = "A Guid should be 36 characters long!")]
    public Guid NutritionId { get; set; }

    [Required]
    public int Quantity { get; set; }

    [Required]
    [DataType(DataType.DateTime)]
    public DateTime GivenDate { get; set; }
}