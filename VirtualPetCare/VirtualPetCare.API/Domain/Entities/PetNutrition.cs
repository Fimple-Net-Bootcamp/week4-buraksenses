using VirtualPetCare.API.Data.Entity;
using VirtualPetCare.API.Data.Entity.Core;

namespace VirtualPetCare.API.Domain.Entities;

public class PetNutrition : Entity
{
    public Guid PetId { get; set; }

    public Guid NutritionId { get; set; }

    public int Quantity { get; set; }

    public DateTime GivenDate { get; set; }
    
    //Navigation Properties

    public Pet Pet { get; set; }

    public Nutrition Nutrition { get; set; }
}