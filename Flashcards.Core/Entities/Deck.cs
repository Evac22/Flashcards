

namespace Flashcards.Core.Entities;

public class Deck
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public int CategoryId { get; set; }

    public Category Category { get; set; }
    public ICollection<Flashcard> Flashcards { get; set; }
}
