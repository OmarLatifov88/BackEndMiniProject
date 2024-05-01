﻿namespace Backend_Project.Models;

public class Brand
{
	public int Id { get; set; }

	public string Name { get; set; }

	public int ProductId { get; set; }

	public Product Product { get; set; }
}
