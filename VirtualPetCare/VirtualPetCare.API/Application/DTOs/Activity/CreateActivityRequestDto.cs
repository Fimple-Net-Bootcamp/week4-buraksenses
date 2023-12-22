using System.ComponentModel.DataAnnotations;

namespace VirtualPetCare.API.Application.DTOs.Activity;

public class CreateActivityRequestDto
{
    public string Name { get; set; }
    public float Duration { get; set; }
    
    public float? DistanceTaken { get; set; }
    public Guid PetId { get; set; }
}