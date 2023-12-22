using System.ComponentModel.DataAnnotations;

namespace VirtualPetCare.API.Application.DTOs.User;

public class CreateUserRequestDto
{
    public string Name { get; set; }
    public string Surname { get; set; }
    public string Email { get; set; }
}