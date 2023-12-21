using VirtualPetCare.API.Data.Entity;
using VirtualPetCare.API.Data.Entity.Core;

namespace VirtualPetCare.API.Domain.Entities;

public class HealthStatus : Entity
{
    public DateTime CheckupDate { get; set; }

    public string Notes { get; set; }

    public string VaccinationStatus { get; set; }

    public Guid PetId { get; set; }
    
    //Navigation Properties
    public Pet Pet { get; set; }
}