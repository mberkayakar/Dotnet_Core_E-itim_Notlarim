using ASP_NET_WEB_APP_İNTRO.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_NET_WEB_APP_İNTRO.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;


        // Controller in constructor ü
        public HomeController(ILogger<HomeController> logger)
        {
            // dependency injection örneğidir.
            _logger = logger;
        }

        public IActionResult Index()
        {
            // varsayılan olarak index isimli bir adet aksiyon geldiğinde gerekli view i döndürecektir.
            return View();
        }

        // ilk model denemesi 
        
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View();

            // new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier }
        }
    }
}
