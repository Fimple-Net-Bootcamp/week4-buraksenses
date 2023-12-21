using VirtualPetCare.API.Data.Entity.Core;

namespace VirtualPetCare.API.Domain.Entities;

public class SocialInteraction : Entity
{
    public SocialInteraction()
    {
        Pets = new List<Pet>();
    }
    
    public string Name { get; set; }

    public DateTime StartDate { get; set; }

    public DateTime EndDate { get; set; }

    public string Location { get; set; }
    
    //Navigation Properties
    public ICollection<Pet> Pets { get; set; }
}