using Microsoft.AspNetCore.Mvc;

namespace Backend_Project.Controllers
{
	public class UserController : Controller
	{
		public IActionResult Register()
		{
			return View();
		}

	}
}
