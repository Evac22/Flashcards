using Microsoft.AspNetCore.Mvc;

namespace Flashcards.Web.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
