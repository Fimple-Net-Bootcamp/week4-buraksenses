using FluentValidation;
using VirtualPetCare.API.Application.DTOs.Training;

namespace VirtualPetCare.API.Application.Validators.Training;

public class CreateTrainingValidator : AbstractValidator<CreateTrainingForPetRequestDto>
{
    public CreateTrainingValidator()
    {
        RuleFor(x => x.Name)
            .NotEmpty().WithMessage("Name is required.")
            .MaximumLength(50).WithMessage("Name must be less than 50 characters.")
            .Matches("^[^çÇıİğĞöÖşŞüÜ]*$").WithMessage("Name must not contain Turkish characters.");

        RuleFor(x => x.Duration)
            .NotEmpty().WithMessage("Duration is required.")
            .GreaterThan(0).WithMessage("Duration must be greater than zero.");

        RuleFor(x => x.PetId)
            .NotEmpty().WithMessage("PetId is required.")
            .Must(id => id != Guid.Empty && id.ToString().Length == 36).WithMessage("PetId must be a valid 36-character Guid.");
    }
}