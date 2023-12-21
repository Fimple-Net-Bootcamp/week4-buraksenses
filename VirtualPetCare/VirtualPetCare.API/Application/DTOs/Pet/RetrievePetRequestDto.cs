namespace VirtualPetCare.API.Application.DTOs.Pet;

public class RetrievePetRequestDto
{
    public string Name { get; set; }

    public string Type { get; set; }

    public string Gender { get; set; }

    public string Color { get; set; }
    
    public float Weight { get; set; }
    
    public Guid UserId { get; set; }
}