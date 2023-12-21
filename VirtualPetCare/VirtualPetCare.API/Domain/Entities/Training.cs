namespace VirtualPetCare.API.Domain.Entities;

public class Training
{
    public Guid Id { get; set; }

    public string Name { get; set; }

    public int Duration { get; set; }

    // Foreign key property
    public Guid PetId { get; set; }

    // Navigation property
    public Pet Pet { get; set; }
}