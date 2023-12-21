using System.ComponentModel.DataAnnotations;

namespace VirtualPetCare.API.Application.DTOs.User;

public class CreateUserRequestDto
{
    [Required]
    [MaxLength(30,ErrorMessage = "Name has to be a maximum of 30 characters!")]
    public string Name { get; set; }

    [Required]
    [MaxLength(30,ErrorMessage = "Surname has to be a maximum of 30 characters!")]
    public string Surname { get; set; }

    [Required]
    [DataType(DataType.EmailAddress)]
    public string Email { get; set; }
}