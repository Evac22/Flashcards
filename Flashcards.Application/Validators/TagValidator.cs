using Flashcards.Application.DTOs;
using FluentValidation;

namespace Flashcards.Application.Validators;

public class TagValidator : AbstractValidator<TagDto>
{
    public TagValidator()
    {
        RuleFor(x => x.Name).NotEmpty().WithMessage("Tag name is required.");
    }
}