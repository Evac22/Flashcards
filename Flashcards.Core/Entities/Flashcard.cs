

namespace Flashcards.Core.Entities;

public class Flashcard
{
    public int Id { get; set; }
    public string Question { get; set; }
    public string Answer { get; set; }
    public string FilePath { get; set; }
    public int DeckId { get; set; }

    public Deck Deck { get; set; }
    public ICollection<Tag> Tags { get; set; }
}
