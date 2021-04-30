using Microsoft.AspNetCore.Mvc;
using WebApplication6.ViewModels;
using System;

namespace WebApplication6.Controllers
{
    public class HomeController:Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult MPinSingleAction()
        {
            return View();
        }
        public IActionResult MPinSeparateAction()
        {
            return View();
        }
        public IActionResult ModelBindingsPar()
        {
            return View();
        }
        public IActionResult ModelBindingsSepModel()
        {
            return View();
        }

        public IActionResult MPinSA()
        {
            if (Request.Method.Equals("POST", StringComparison.OrdinalIgnoreCase))
            {
                var value1 = Convert.ToInt32(Request.Form["input1"]);
                var value2 = Convert.ToInt32(Request.Form["input2"]);
                var operation = Request.Form["operation"];

                ViewBag.output1 = value1;
                ViewBag.output2 = value2;
                ViewBag.operation = operation;
                ViewBag.result = Calc(value1, value2, operation);
            }
            return View("Result");
        }

        [HttpGet]
        public IActionResult MPinSepA()
        {
            return View("MPinSeparateAction");
        }

        [HttpPost, ActionName("MPinSepA")]
        public IActionResult MPinSepAPost()
        {
            var value1 = Convert.ToInt32(Request.Form["input1"]);
            var value2 = Convert.ToInt32(Request.Form["input2"]);
            var operation = Request.Form["operation"];

            ViewBag.output1 = value1;
            ViewBag.output2 = value2;
            ViewBag.operation = operation;
            ViewBag.result = Calc(value1, value2, operation);
            return View("Result");
        }

        [HttpPost]
        public IActionResult ModBindPar(int input1, int input2, string operation)
        {
            ViewBag.output1 = input1;
            ViewBag.output2 = input2;
            ViewBag.operation = operation;
            ViewBag.result = Calc(input1, input2, operation);
            return View("Result");
        }

        public IActionResult ModBindSepMod(CalcOperation calc)
        {
            ViewBag.output1 = calc.input1;
            ViewBag.output2 = calc.input2;
            ViewBag.operation = calc.operation;
            ViewBag.result = calc.Calc();
            return View("Result");
        }

        string Calc(int inp1, int inp2, string oper)
        {
            string res = "";
            if (oper == "+") { res = (inp1 + inp2).ToString(); }
            if (oper == "-") { res = (inp1 - inp2).ToString(); }
            if (oper == "*") { res = (inp1 * inp2).ToString(); }
            if (oper == "/") {
                if (inp2 == 0) res = "divider is eaquel 0";
                else res = ((double)inp1 / inp2).ToString();
            }
            return res;
        }

    }
}
