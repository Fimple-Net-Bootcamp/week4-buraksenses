using System.ComponentModel.DataAnnotations;

namespace VirtualPetCare.API.Application.DTOs.HealthStatus;

public class UpdateHealthStatusRequestDto
{
    [Required]
    [DataType(DataType.DateTime)]
    public DateTime CheckupDate { get; set; }

    [Required]
    [MaxLength(80,ErrorMessage = "Notes has to be a maximum of 80 characters!")]
    public string Notes { get; set; }

    [Required]
    [MaxLength(25,ErrorMessage = "VaccinationStatus has to be maximum of 25 characters!")]
    public string VaccinationStatus { get; set; }
}