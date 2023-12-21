namespace VirtualPetCare.API.Application.DTOs.HealthStatus;

public class RetrieveHealthStatusRequestDto
{
    public DateTime CheckupDate { get; set; }

    public string Notes { get; set; }

    public string VaccinationStatus { get; set; }

    public Guid PetId { get; set; }
}