using FluentValidation;
using VirtualPetCare.API.Application.DTOs.PetNutrition;

namespace VirtualPetCare.API.Application.Validators.Nutritions;

public class CreateNutritionValidator : AbstractValidator<CreatePetNutritionRequestDto>
{
    public CreateNutritionValidator()
    {
        RuleFor(x => x.NutritionId)
            .NotEmpty().WithMessage("NutritionId is required.")
            .Must(id => id != Guid.Empty).WithMessage("NutritionId cannot be empty Guid.");

        RuleFor(x => x.Quantity)
            .NotEmpty().WithMessage("Quantity is required.")
            .GreaterThan(0).WithMessage("Quantity must be greater than zero.");

        RuleFor(x => x.GivenDate)
            .NotEmpty().WithMessage("GivenDate is required.")
            .Must(date => date != default).WithMessage("GivenDate must be a valid date.");
    }
}