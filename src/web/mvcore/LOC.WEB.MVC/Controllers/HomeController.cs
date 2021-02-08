using Microsoft.AspNetCore.Mvc;

namespace LOC.WEB.MVC.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
