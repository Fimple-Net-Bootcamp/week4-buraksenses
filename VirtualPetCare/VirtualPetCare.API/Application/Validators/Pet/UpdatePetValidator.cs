using FluentValidation;
using VirtualPetCare.API.Application.DTOs.Pet;

namespace VirtualPetCare.API.Application.Validators.Pet;

public class UpdatePetValidator : AbstractValidator<UpdatePetRequestDto>
{
    public UpdatePetValidator()
    {
        RuleFor(x => x.Name)
            .NotEmpty().WithMessage("Name is required.")
            .MaximumLength(30).WithMessage("Name has to be a maximum of 30 characters!");

        RuleFor(x => x.Color)
            .NotEmpty().WithMessage("Color is required.");

        RuleFor(x => x.Weight)
            .NotEmpty().WithMessage("Weight is required.")
            .GreaterThan(0).WithMessage("Weight must be greater than zero.");
    }
}