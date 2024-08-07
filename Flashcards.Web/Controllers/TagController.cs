using Microsoft.AspNetCore.Mvc;

namespace Flashcards.Web.Controllers
{
    public class TagController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
