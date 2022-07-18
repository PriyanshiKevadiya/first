using Microsoft.AspNetCore.Mvc;

namespace first1.Views
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
