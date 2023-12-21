using VirtualPetCare.API.Data.Entity.Core;

namespace VirtualPetCare.API.Domain.Entities;

public class Pet : Entity
{
    public Pet()
    {
        Trainings = new List<Training>();
        SocialInteractions = new List<SocialInteraction>();
    }
    
    public string Name { get; set; }

    public string Type { get; set; }

    public string Gender { get; set; }

    public string Color { get; set; }
    
    public float Weight { get; set; }

    public Guid UserId { get; set; }

    //Navigation Properties
    public User User { get; set; }

    public ICollection<Training> Trainings { get; set; }

    public ICollection<SocialInteraction> SocialInteractions { get; set; }
}