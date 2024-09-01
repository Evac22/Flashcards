using Flashcards.Application.DTOs;
using FluentValidation;


namespace Flashcards.Application.Validators
{
    public class ApplicationUserValidator : AbstractValidator<ApplicationUserDto>
    {
        public ApplicationUserValidator()
        {
            RuleFor(x => x.FullName).NotEmpty().WithMessage("Full name is required.");
            RuleFor(x => x.Email).EmailAddress().WithMessage("Invalid email address.");
        }
    }
}
