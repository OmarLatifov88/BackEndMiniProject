using Microsoft.AspNetCore.Identity;

namespace Backend_Project.Models
{
	public class AppUser : IdentityUser
	{
		public string Fullname { get; set; }

		public bool IsActive { get; set; }
	}
}
