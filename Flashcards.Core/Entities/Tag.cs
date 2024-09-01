

namespace Flashcards.Core.Entities;

public class Tag
{
    public int Id { get; set; }
    public string Name { get; set; }
    public ICollection<Flashcard> Flashcards { get; set; }
}

