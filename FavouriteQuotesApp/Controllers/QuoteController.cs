using Microsoft.AspNetCore.Mvc;

namespace FavouriteQuotesApp.Controllers
{
    public class QuoteController : Controller
    {
        public IActionResult Items()
        {
            return View();
        }
    }
}
