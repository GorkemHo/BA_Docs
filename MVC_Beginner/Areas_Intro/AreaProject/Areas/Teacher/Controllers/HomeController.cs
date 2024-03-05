using Microsoft.AspNetCore.Mvc;

namespace AreaProject.Areas.Teacher.Controllers
{
    [Area("Teacher")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
