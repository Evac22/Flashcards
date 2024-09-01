using Flashcards.Application.DTOs;
using FluentValidation;

namespace Flashcards.Application.Validators;

public class DeckValidator : AbstractValidator<DeckDto>
{
    public DeckValidator()
    {
        RuleFor(x => x.Title).NotEmpty().WithMessage("Deck title is required.");
    }
}
