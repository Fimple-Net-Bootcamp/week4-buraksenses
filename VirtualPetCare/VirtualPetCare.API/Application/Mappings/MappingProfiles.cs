using AutoMapper;
using VirtualPetCare.API.Application.DTOs.Activity;
using VirtualPetCare.API.Application.DTOs.HealthStatus;
using VirtualPetCare.API.Application.DTOs.Nutrition;
using VirtualPetCare.API.Application.DTOs.Pet;
using VirtualPetCare.API.Application.DTOs.PetNutrition;
using VirtualPetCare.API.Application.DTOs.User;
using VirtualPetCare.API.Data.Entity;
using VirtualPetCare.API.Domain.Entities;

namespace VirtualPetCare.API.Application.Mappings;

public class MappingProfiles : Profile
{
    public MappingProfiles()
    {
        //USER MAPPINGS
        CreateMap<User, CreateUserRequestDto>().ReverseMap();

        CreateMap<User, RetrieveUserRequestDto>().ReverseMap();

        //PET MAPPINGS
        CreateMap<Pet, RetrievePetRequestDto>().ReverseMap();

        CreateMap<Pet, CreatePetRequestDto>().ReverseMap();

        CreateMap<Pet, UpdatePetRequestDto>().ReverseMap();
        
        //ACTIVITY MAPPINGS
        CreateMap<Activity, CreateActivityRequestDto>().ReverseMap();

        CreateMap<Activity, RetrieveActivityRequestDto>().ReverseMap();
        
        //NUTRITION MAPPINGS
        CreateMap<Nutrition, CreateNutritionRequestDto>().ReverseMap();

        CreateMap<Nutrition, RetrieveNutritionRequestDto>().ReverseMap();
        
        //PETNUTRITION MAPPINGS
        CreateMap<PetNutrition, CreatePetNutritionRequestDto>().ReverseMap();
        
        //HEALTHSTATUS MAPPINGS
        CreateMap<HealthStatus, RetrieveHealthStatusRequestDto>().ReverseMap();
        
        CreateMap<HealthStatus, UpdateHealthStatusRequestDto>().ReverseMap();
    }
}