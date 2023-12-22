namespace VirtualPetCare.API.Application.DTOs.Pet;

public class UpdatePetRequestDto
{
    public string Name { get; set; }
    public string Color { get; set; }
    public float Weight { get; set; }
}