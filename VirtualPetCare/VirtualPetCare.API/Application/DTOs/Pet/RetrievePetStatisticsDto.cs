using VirtualPetCare.API.Application.DTOs.Activity;
using VirtualPetCare.API.Application.DTOs.HealthStatus;
using VirtualPetCare.API.Application.DTOs.Nutrition;

namespace VirtualPetCare.API.Application.DTOs.Pet;

public class RetrievePetStatisticsDto
{
    public ICollection<RetrieveActivityRequestDto> Activities { get; set; }

    public RetrieveHealthStatusRequestDto HealthStatus { get; set; }

    public ICollection<RetrieveNutritionRequestDto> Nutritions { get; set; }
}