using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace WebApplication6.Controllers
{
    public class HomeController:Controller
    {
        public IActionResult Index()
        {
            return View();
        }

       
    }
}
