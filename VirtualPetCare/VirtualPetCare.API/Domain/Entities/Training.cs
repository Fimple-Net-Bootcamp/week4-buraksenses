using VirtualPetCare.API.Data.Entity.Core;

namespace VirtualPetCare.API.Domain.Entities;

public class Training : Entity
{
    public string Name { get; set; }

    public int Duration { get; set; }

    // Foreign key property
    public Guid PetId { get; set; }

    // Navigation property
    public Pet Pet { get; set; }
}