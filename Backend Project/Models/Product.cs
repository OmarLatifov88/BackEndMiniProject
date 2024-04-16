﻿namespace Backend_Project.Models;

public class Product
{
	public int Id { get; set; }
	
	public string Name { get; set; }

	public int Price { get; set; }
	
	public string Description { get; set; }

	public int Rate { get; set; }
	
	public string Offer { get; set; }

	public int BrandId { get; set; }

	public int CategoryId { get; set; }
}
