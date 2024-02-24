using Microsoft.AspNetCore.Mvc;

namespace WebbyApple_Mission05_ZWE.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult FanMail()
        {
            return View();
        }
    }
}
