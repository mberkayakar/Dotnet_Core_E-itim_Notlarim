using Microsoft.AspNetCore.Mvc;

namespace MvcWebUI.Controllers
{
    public class HomeController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
