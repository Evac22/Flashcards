using FluentValidation;
using Flashcards.Application.DTOs;

namespace Flashcards.Application.Validators;

public class CategoryValidator : AbstractValidator<CategoryDto>
{
    public CategoryValidator()
    {
        RuleFor(x => x.Name).NotEmpty().WithMessage("Category name is required.");
    }
}

