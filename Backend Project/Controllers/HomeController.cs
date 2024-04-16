using Backend_Project.Contexts;
using Microsoft.AspNetCore.Mvc;

namespace Backend_Project.Controllers
{
    public class HomeController : Controller
    {
        private readonly RiodeDbContext _Context;

		public HomeController(RiodeDbContext context)
		{
			_Context = context;
		}

		public IActionResult Index()
        {
            return View();
        }
    }
}
