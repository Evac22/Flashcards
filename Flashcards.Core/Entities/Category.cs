

namespace Flashcards.Core.Entities;

public class Category
{
    public int Id { get; set; }
    public string Name { get; set; }

    public ICollection<Deck> Decks { get; set; }
}
