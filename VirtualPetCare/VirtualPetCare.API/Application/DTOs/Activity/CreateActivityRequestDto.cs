using System.ComponentModel.DataAnnotations;

namespace VirtualPetCare.API.Application.DTOs.Activity;

public class CreateActivityRequestDto
{
    [Required]
    [MaxLength(30,ErrorMessage = "Name has to be a maximum of 30 characters!")]
    public string Name { get; set; }

    [Required]
    public float Duration { get; set; }
    
    public float? DistanceTaken { get; set; }

    [Required]
    [MaxLength(36,ErrorMessage = "A Guid should be 36 characters long!")]
    [MinLength(36,ErrorMessage = "A Guid should be 36 characters long!")]
    public Guid PetId { get; set; }
}