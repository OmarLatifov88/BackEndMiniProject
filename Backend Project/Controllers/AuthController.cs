using Microsoft.AspNetCore.Mvc;

namespace Backend_Project.Controllers
{
    public class AuthController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
