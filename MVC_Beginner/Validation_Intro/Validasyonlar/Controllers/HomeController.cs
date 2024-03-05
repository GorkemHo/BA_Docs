using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Validasyonlar.Models;
using Validasyonlar.Models.Entities;

namespace Validasyonlar.Controllers
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
            User user = new User();
            return View(user);
        }
        [HttpPost]
        public IActionResult Index(User user)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("Details",user);

            }
            return View();
        }
        public IActionResult Details(User user) 
        {
            
            return View(user);
        }

        public IActionResult Privacy()
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
