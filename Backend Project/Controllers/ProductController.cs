﻿using Microsoft.AspNetCore.Mvc;

namespace Backend_Project.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
