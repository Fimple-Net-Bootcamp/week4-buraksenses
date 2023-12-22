using FluentValidation;
using VirtualPetCare.API.Application.DTOs.SocialInteraction;

namespace VirtualPetCare.API.Application.Validators.SocialInteraction;

public class CreateSocialInteractionValidator : AbstractValidator<CreateSocialInteractionRequestDto>
{
    public CreateSocialInteractionValidator()
    {
        RuleFor(x => x.Name)
            .NotEmpty().WithMessage("Name is required.")
            .MaximumLength(50).WithMessage("Name must be less than 50 characters.");

        RuleFor(x => x.StartDate)
            .NotEmpty().WithMessage("Start date is required.")
            .LessThan(x => x.EndDate).WithMessage("Start date must be before the end date.")
            .GreaterThan(DateTime.Today).WithMessage("Start date must be later than today!");

        RuleFor(x => x.EndDate)
            .NotEmpty().WithMessage("End date is required.")
            .GreaterThan(x => x.StartDate).WithMessage("End date must be after the start date.");

        RuleFor(x => x.Location)
            .NotEmpty().WithMessage("Location is required.")
            .MaximumLength(200).WithMessage("Location must be less than 200 characters.");

        RuleFor(x => x.PetIds)
            .NotEmpty().WithMessage("At least one pet ID is required.")
            .Must(petIds => petIds.All(id => id != Guid.Empty)).WithMessage("Pet IDs must not be empty Guids.")
            .ForEach(petIdRule =>
            {
                petIdRule.NotEmpty().WithMessage("Pet ID must not be empty")
                    .Must(petId => petId.ToString().Length == 36).WithMessage("A Guid must be 36 characters long!");
            });
    }
}