using VirtualPetCare.API.Data.Entity;
using VirtualPetCare.API.Domain.Entities;

namespace VirtualPetCare.API.Persistence;

public class Seed
{
    public static async Task SeedData(VirtualPetCareDbContext context)
    {
        List<User> users = new List<User>();
        List<Pet> pets = new List<Pet>();
        List<Activity> activities = new List<Activity>();
        List<HealthStatus> healthStatusList = new List<HealthStatus>();
        List<Nutrition> nutritions = new List<Nutrition>();
        
         // Seed Users
         if (!context.Users.Any())
         {
             users = new List<User>
             {
                 new User { Name = "John", Surname = "Doe", Email = "johndoe@example.com" },
                 new User { Name = "Jane", Surname = "Doe", Email = "janedoe@example.com" }
             };
        
             await context.Users.AddRangeAsync(users);
         }
        
         // Seed Pets
         if (!context.Pets.Any())
         {
             pets = new List<Pet>
             {
                 new Pet { Name = "Buddy", Type = "Dog", Gender = "Male", Color = "Brown", UserId = users[0].Id },
                 new Pet { Name = "Misty", Type = "Cat", Gender = "Female", Color = "Black", UserId = users[1].Id }
             };
        
             await context.Pets.AddRangeAsync(pets);
         }
        
         // Seed Activities
         if (!context.Activities.Any())
         {
             activities = new List<Activity>
             {
                 new Activity { Name = "Walk in the park", Duration = 30, DistanceTaken = 2, PetId = pets[0].Id },
                 new Activity { Name = "Playtime", Duration = 20, PetId = pets[1].Id }
             };
        
             await context.Activities.AddRangeAsync(activities);
         }
        
         // Seed HealthStatuses
         if (!context.HealthStatusList.Any())
         {
             healthStatusList = new List<HealthStatus>
             {
                 new HealthStatus { CheckupDate = DateTime.UtcNow.AddDays(-30), Notes = "Healthy", VaccinationStatus = "Up to date", PetId = pets[0].Id },
                 new HealthStatus { CheckupDate = DateTime.UtcNow.AddDays(-20), Notes = "Good", VaccinationStatus = "Up to date", PetId = pets[1].Id }
             };
        
             await context.HealthStatusList.AddRangeAsync(healthStatusList);
         }
        
         // Seed Nutritions
         if (!context.Nutritions.Any())
         {
             nutritions = new List<Nutrition>
             {
                 new Nutrition { Name = "Dog Food", Calories = 300, ForWhichPet = new string[] { "Dog" }, Quantity = 100 },
                 new Nutrition { Name = "Cat Food", Calories = 250, ForWhichPet = new string[] { "Cat" }, Quantity = 100 }
             };
        
             await context.Nutritions.AddRangeAsync(nutritions);
         }

         //Save changes
        await context.SaveChangesAsync();
    }
}
