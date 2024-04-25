using Microsoft.AspNetCore.Mvc;

namespace Backend_Project.Controllers
{
    public class CategoriesController : Controller
    {
        public IActionResult Categories()
        {
            return View();
        }
    }
}
