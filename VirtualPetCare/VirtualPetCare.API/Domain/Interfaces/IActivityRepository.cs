using VirtualPetCare.API.Application.DTOs.Activity;
using VirtualPetCare.API.Data.Entity;

namespace VirtualPetCare.API.Domain.Interfaces;

public interface IActivityRepository
{
    Task<List<Activity>?> GetPetActivities(Guid petId);

    Task<Activity> CreateAsync(Activity activity);
}