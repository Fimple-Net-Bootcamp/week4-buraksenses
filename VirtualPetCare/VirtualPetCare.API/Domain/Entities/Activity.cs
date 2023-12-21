namespace VirtualPetCare.API.Data.Entity;
using Core;

public class Activity : Entity
{
    public string Name { get; set; }

    public float Duration { get; set; }

    public float? DistanceTaken { get; set; }

    public Guid PetId { get; set; }
    
    //Navigation Properties
    public Pet Pet { get; set; }
}