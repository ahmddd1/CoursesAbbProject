using System.Diagnostics;
using CoursesAbb.Models;
using Microsoft.AspNetCore.Mvc;

namespace CoursesAbb.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult index()
        {
            return View();
        }

        public IActionResult course()
        {
            return View();
        }
        public IActionResult about()
        {
            return View();
        }
        public IActionResult teacher()
        {
            return View();
        }
        public IActionResult contact()
        {
            return View();
        }
       

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
