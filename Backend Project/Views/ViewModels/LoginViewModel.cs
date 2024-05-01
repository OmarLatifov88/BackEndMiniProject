using System.ComponentModel.DataAnnotations;

namespace Backend_Project.Views.ViewModels;

public class LoginViewModel
{
	[Required]
	public string UsernameOrEmail { get; set; }
	[Required, DataType(DataType.Password)]
	public string Password { get; set; }
}
