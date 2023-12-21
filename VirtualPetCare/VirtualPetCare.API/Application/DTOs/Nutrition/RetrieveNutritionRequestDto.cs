using Newtonsoft.Json;

namespace VirtualPetCare.API.Application.DTOs.Nutrition;

public class RetrieveNutritionRequestDto
{
    public string Name { get; set; }

    public float Calories { get; set; }
    
    public string[]? ForWhichPet { get; set; }
    
    public int Quantity { get; set; }
}