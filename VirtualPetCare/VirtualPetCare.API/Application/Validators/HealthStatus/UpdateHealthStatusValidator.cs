using FluentValidation;
using VirtualPetCare.API.Application.DTOs.HealthStatus;

namespace VirtualPetCare.API.Application.Validators.HealthStatus;

public class UpdateHealthStatusValidator : AbstractValidator<UpdateHealthStatusRequestDto>
{
    public UpdateHealthStatusValidator()
    {
        RuleFor(x => x.CheckupDate)
            .NotEmpty().WithMessage("Checkup date is required.");

        RuleFor(x => x.Notes)
            .NotEmpty().WithMessage("Notes are required.")
            .MaximumLength(80).WithMessage("Notes has to be a maximum of 80 characters!");

        RuleFor(x => x.VaccinationStatus)
            .NotEmpty().WithMessage("Vaccination status is required.")
            .MaximumLength(25).WithMessage("VaccinationStatus has to be maximum of 25 characters!");
    }
}