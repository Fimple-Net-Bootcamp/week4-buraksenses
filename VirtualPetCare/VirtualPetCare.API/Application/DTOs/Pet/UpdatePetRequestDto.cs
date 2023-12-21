using System.ComponentModel.DataAnnotations;

namespace VirtualPetCare.API.Application.DTOs.Pet;

public class UpdatePetRequestDto
{
    [Required]
    [MaxLength(30,ErrorMessage = "Name has to be a maximum of 30 characters!")]
    public string Name { get; set; }

    [Required]
    public string Color { get; set; }
    
    [Required]
    public float Weight { get; set; }
}