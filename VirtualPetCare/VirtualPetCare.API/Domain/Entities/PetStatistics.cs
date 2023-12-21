using VirtualPetCare.API.Data.Entity;

namespace VirtualPetCare.API.Domain.Entities;

public class PetStatistics
{
    public ICollection<Activity>? Activities { get; set; }

    public ICollection<Nutrition>? Nutritions { get; set; }

    public HealthStatus? HealthStatus { get; set; }
}