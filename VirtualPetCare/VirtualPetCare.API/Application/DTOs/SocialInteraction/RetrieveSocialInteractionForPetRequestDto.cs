namespace VirtualPetCare.API.Application.DTOs.SocialInteraction;

public class RetrieveSocialInteractionForPetRequestDto
{
    public string Name { get; set; }

    public DateTime StartDate { get; set; }
    
    public DateTime EndDate { get; set; }

    public string Location { get; set; }
}