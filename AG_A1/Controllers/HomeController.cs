using Microsoft.AspNetCore.Mvc;

namespace AG_A1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
