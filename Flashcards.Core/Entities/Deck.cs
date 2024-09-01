

namespace Flashcards.Core.Entities;

public class Deck
{
    public int Id { get; set; }
    public string Title { get; set; }
    public ICollection<Flashcard> Flashcards { get; set; }
}
