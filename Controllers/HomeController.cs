using GibJohnTutoring.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace GibJohnTutoring.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Booking()
        {
            return View();
        }

        public IActionResult Functions()
        {
            return View();
        }

        public IActionResult Collaborate()
        {
            return View();
        }

        public IActionResult Resources()
        {
            return View();
        }

        public IActionResult Games()
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
