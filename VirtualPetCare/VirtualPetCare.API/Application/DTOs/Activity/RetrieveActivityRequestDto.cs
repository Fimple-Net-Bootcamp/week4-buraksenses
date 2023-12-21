namespace VirtualPetCare.API.Application.DTOs.Activity;

public class RetrieveActivityRequestDto
{
    public string Name { get; set; }

    public float Duration { get; set; }

    public float? DistanceTaken { get; set; }

    public Guid PetId { get; set; }
}