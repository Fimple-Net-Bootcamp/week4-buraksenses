using System.ComponentModel.DataAnnotations.Schema;
using Newtonsoft.Json;

namespace VirtualPetCare.API.Data.Entity;
using Core;

public class Nutrition : Entity
{
    public string Name { get; set; }

    public float Calories { get; set; }

    [Column(TypeName = "text")]
    public string ForWhichPetJson
    {
        get => JsonConvert.SerializeObject(ForWhichPet);
        set => ForWhichPet = JsonConvert.DeserializeObject<string[]>(value);
    }

    [NotMapped]
    public string[]? ForWhichPet { get; set; }
    
    public int Quantity { get; set; }

    public ICollection<Pet> Pets { get; set; }
}