using VirtualPetCare.API.Data.Entity.Core;

namespace VirtualPetCare.API.Domain.Entities;

public class User : Entity
{
    public string Name { get; set; }

    public string Surname { get; set; }

    public string Email { get; set; }
}