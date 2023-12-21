using System.ComponentModel.DataAnnotations;

namespace VirtualPetCare.API.Application.DTOs.Pet;

public class CreatePetRequestDto
{
    [Required]
    [MaxLength(30,ErrorMessage = "Name has to be a maximum of 30 characters!")]
    public string Name { get; set; }

    [Required]
    public string Type { get; set; }

    [Required]
    public string Gender { get; set; }

    [Required]
    public string Color { get; set; }
    
    [Required]
    public float Weight { get; set; }

    [Required]
    [MaxLength(36,ErrorMessage = "A Guid should be 36 characters long!")]
    [MinLength(36,ErrorMessage = "A Guid should be 36 characters long!")]
    public Guid UserId { get; set; }
}