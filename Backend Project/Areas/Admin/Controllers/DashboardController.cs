using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Backend_Project.Areas.Admin.Controllers;
[Area("Admin")]
[Authorize(Roles = "Admin,Moderator")]
[AllowAnonymous]
public class DashboardController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
