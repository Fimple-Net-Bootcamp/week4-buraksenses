namespace VirtualPetCare.API.Application.DTOs.Training;

public class CreateTrainingForPetRequestDto
{
    public string Name { get; set; }

    public int Duration { get; set; }

    public string PetName { get; set; }
}