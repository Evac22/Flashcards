using Flashcards.Application.DTOs;
using FluentValidation;


namespace Flashcards.Application.Validators;

public class FlashcardValidator : AbstractValidator<FlashcardDto>
{
    public FlashcardValidator()
    {
        RuleFor(x => x.Question).NotEmpty().WithMessage("Question is required.");
        RuleFor(x => x.Answer).NotEmpty().WithMessage("Answer is required.");
        RuleFor(x => x.CategoryId).GreaterThan(0).WithMessage("CategoryId is required.");
        RuleFor(x => x.DeckId).GreaterThan(0).WithMessage("DeckId is required.");
    }
}
