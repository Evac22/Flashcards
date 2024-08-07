using Microsoft.AspNetCore.Mvc;

namespace Flashcards.Web.Controllers
{
    public class FlashcardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
