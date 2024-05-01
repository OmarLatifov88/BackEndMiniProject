using Backend_Project.Helpers.Enums;
using Backend_Project.Models;
using Backend_Project.Views.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace Backend_Project.Controllers;

public class AuthController : Controller
{
	private readonly UserManager<AppUser> _userManager;
	private readonly SignInManager<AppUser> _signInManager;
	private readonly RoleManager<IdentityRole> _roleManager;
	public AuthController(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager, RoleManager<IdentityRole> roleManager)
	{
		_userManager = userManager;
		_signInManager = signInManager;
		_roleManager = roleManager;
	}

	public IActionResult Login()
	{
		var text = User.Identity.Name;

		if (User.Identity.IsAuthenticated)
			return RedirectToAction("Index", "Home");

		return View();
	}

	[HttpPost]
	public async Task<IActionResult> Login(LoginViewModel loginViewModel)
	{
		if (User.Identity.IsAuthenticated)
			return RedirectToAction("Index", "Home");

		if (!ModelState.IsValid)
			return View();

		var user = await _userManager.FindByNameAsync(loginViewModel.UsernameOrEmail);
		if (user == null)
		{
			user = await _userManager.FindByEmailAsync(loginViewModel.UsernameOrEmail);
			if (user == null)
			{
				ModelState.AddModelError("", "Username or email incorrect");
				return View();
			}

		}

		var signInResult = await _signInManager.PasswordSignInAsync(user.UserName,
			loginViewModel.Password, true, false);

		if (!signInResult.Succeeded)
		{
			ModelState.AddModelError("", "Username or email incorrect");
			return View();
		}

		return RedirectToAction("Index", "Home");
	}

	public async Task<IActionResult> Logout()
	{
		await _signInManager.SignOutAsync();

		return RedirectToAction("Index", "Home");
	}

	public async Task<IActionResult> CreateRole()
	{
		foreach (var roleName in Enum.GetNames(typeof(Roles)))
		{
			await _roleManager.CreateAsync(new IdentityRole { Name = roleName });
		}
		//await _roleManager.CreateAsync(new IdentityRole { Name = "Admin" });
		//await _roleManager.CreateAsync(new IdentityRole { Name = "User" });
		//await _roleManager.CreateAsync(new IdentityRole { Name = "Moderator" });

		return Content("Rollar Yarandi");
	}

	public IActionResult ForgotPassword()
	{
		return View();
	}
}


