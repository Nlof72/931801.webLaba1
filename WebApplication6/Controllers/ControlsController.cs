using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication6.Controllers
{
    public class ControlsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult TextBox()
        {
            return View();
        } 
        public IActionResult TextArea()
        {
            return View();
        } 
        public IActionResult CheckBox()
        {
            return View();
        }
        public IActionResult Radio()
        {
            return View();
        }
        public IActionResult DropDown()
        {
            return View();
        }
        public IActionResult ListBox()
        {
            return View();
        }
        public IActionResult Result()
        {
            return View();
        }

        [HttpPost]
        public IActionResult GetDataFromView(string input1, string value, string tag)
        {
            if (value == null) value = "false"; else if (value == "on") value = "true";
            ViewBag.key = input1;
            ViewBag.value = value;
            ViewBag.tag = tag;
            return View("Result");
        }
    }
}
