﻿using Microsoft.AspNetCore.Mvc;

namespace PortfolioCore.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index() //Metod türü
        {
            return View();
        }
    }
}
