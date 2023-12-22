using System.ComponentModel.DataAnnotations;

namespace VirtualPetCare.API.Application.DTOs.HealthStatus;

public class UpdateHealthStatusRequestDto
{
    public DateTime CheckupDate { get; set; }

    public string Notes { get; set; }

    public string VaccinationStatus { get; set; }
}