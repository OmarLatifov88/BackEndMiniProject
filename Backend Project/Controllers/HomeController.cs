using Backend_Project.Contexts;
using Backend_Project.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

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
            var products = _Context.Products.ToList();
            
          
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Product product) 
        {
            return Content(product.Name);
        }
    }
}
