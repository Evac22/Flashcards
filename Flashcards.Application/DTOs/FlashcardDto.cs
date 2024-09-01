using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flashcards.Application.DTOs
{
    public class FlashcardDto
    {
        public int Id { get; set; }
        public string Question { get; set; }
        public string Answer { get; set; }
        public int CategoryId { get; set; }
        public int DeckId { get; set; }
        public List<int> TagIds { get; set; }
    }

}
