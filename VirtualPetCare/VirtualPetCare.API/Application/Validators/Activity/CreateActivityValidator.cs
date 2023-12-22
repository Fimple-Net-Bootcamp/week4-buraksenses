using FluentValidation;
using VirtualPetCare.API.Application.DTOs.Activity;

namespace VirtualPetCare.API.Application.Validators.Activity;

public class CreateActivityValidator : AbstractValidator<CreateActivityRequestDto>
{
    public CreateActivityValidator()
    {
        RuleFor(a => a.Name)
            .NotEmpty().WithMessage("Can not be empty!")
            .MinimumLength(3).WithMessage("Must be a minimum length of 3!")
            .MaximumLength(15)
            .Matches("^[^çÇıİğĞöÖşŞüÜ].*").WithMessage("Do not use turkish characters!");

        RuleFor(a => a.Duration)
            .NotEmpty()
            .GreaterThanOrEqualTo(15).WithMessage("An activity must last at least 15 minutes!");

        RuleFor(a => a.PetId)
            .NotEmpty().WithMessage("Pet Id field can not be empty!")
            .Must(id => id.ToString().Length == 36).WithMessage("A guid must be 36 characters long!");
    }
}