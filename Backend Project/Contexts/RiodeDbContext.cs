using Backend_Project.Models;
using Microsoft.EntityFrameworkCore;

namespace Backend_Project.Contexts
{
	public class RiodeDbContext : DbContext
	{
		public RiodeDbContext(DbContextOptions<RiodeDbContext> options) : base(options)
		{

		}

		public DbSet<Brand> Brandcs { get; set; } = null;
		public DbSet<Category> Categories { get; set; } = null;
		public DbSet<Product> Products { get; set; } = null;
		public DbSet<ProductImage> ProductImages { get; set; } = null;
	}
}
