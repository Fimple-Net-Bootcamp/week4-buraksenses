using VirtualPetCare.API.Domain.Entities;

namespace VirtualPetCare.API.Data.Entity;
using Core;

public class Pet : Entity
{
    public string Name { get; set; }

    public string Type { get; set; }

    public string Gender { get; set; }

    public string Color { get; set; }
    
    public float Weight { get; set; }

    public Guid UserId { get; set; }

    //Navigation Properties
    public User User { get; set; }
}