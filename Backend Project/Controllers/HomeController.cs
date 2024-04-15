using Microsoft.AspNetCore.Mvc;

namespace Backend_Project.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
