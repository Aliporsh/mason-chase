﻿using Microsoft.AspNetCore.Mvc;

namespace Afshar_test.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}