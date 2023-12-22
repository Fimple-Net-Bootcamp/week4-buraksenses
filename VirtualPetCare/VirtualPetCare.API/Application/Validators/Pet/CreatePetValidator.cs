using FluentValidation;
using VirtualPetCare.API.Application.DTOs.Pet;

namespace VirtualPetCare.API.Application.Validators.Pet;

public class CreatePetValidator : AbstractValidator<CreatePetRequestDto>
{
    public CreatePetValidator()
    {
        RuleFor(x => x.Name)
            .NotEmpty().WithMessage("Name is required.")
            .MaximumLength(30).WithMessage("Name has to be a maximum of 30 characters!");

        RuleFor(x => x.Type)
            .NotEmpty().WithMessage("Type is required.");

        RuleFor(x => x.Gender)
            .NotEmpty().WithMessage("Gender is required.");

        RuleFor(x => x.Color)
            .NotEmpty().WithMessage("Color is required.");
        
        RuleFor(x => x.Weight)
            .NotEmpty().WithMessage("Weight is required.")
            .GreaterThan(0).WithMessage("Weight must be greater than zero.");

        RuleFor(x => x.UserId)
            .NotEmpty().WithMessage("User ID is required.")
            .Must(id => id != Guid.Empty && id.ToString().Length == 36)
            .WithMessage("User ID must be a valid 36-character Guid.");
    }
}