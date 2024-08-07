using Microsoft.AspNetCore.Mvc;

namespace Flashcards.Web.Controllers
{
    public class DeckController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
