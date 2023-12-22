using FluentValidation;
using VirtualPetCare.API.Application.DTOs.User;

namespace VirtualPetCare.API.Application.Validators.User;

public class CreateUserValidator : AbstractValidator<CreateUserRequestDto>
{
    public CreateUserValidator()
    {
        RuleFor(x => x.Name)
            .NotEmpty().WithMessage("Name is required.")
            .MaximumLength(30).WithMessage("Name has to be a maximum of 30 characters!");

        RuleFor(x => x.Surname)
            .NotEmpty().WithMessage("Surname is required.")
            .MaximumLength(30).WithMessage("Surname has to be a maximum of 30 characters!");

        RuleFor(x => x.Email)
            .NotEmpty().WithMessage("Email is required.")
            .EmailAddress().WithMessage("Invalid email address format.");
    }
}