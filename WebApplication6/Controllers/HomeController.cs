using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace WebApplication6.Controllers
{
    public class HomeController:Controller
    {
        Random rnd = new Random();
        static List<string> result = new List<string>();
        static int right = 0;
        static int wrong = 0;
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Quiz()
        {
            GenerateInputNumbersAndOperPlusMinus();
            return View();
        }

        void GenerateInputNumbersAndOperPlusMinus()
        {
            ViewBag.input1 = (int)(rnd.NextDouble() * 10);
            ViewBag.input2 = (int)(rnd.NextDouble() * 10);
            if (rnd.NextDouble() >= 0.5)
            {
                ViewBag.operation = "+";
                return;
            }
            ViewBag.operation = "-";
        }

        [HttpPost]
        public IActionResult Next(int input1, int input2, string operation, int answer)
        {
            if (CheckAnswer(input1, input2, operation, answer)) right++;
            else wrong++;
            result.Add($"{input1} {operation} {input2} = {answer}");
            GenerateInputNumbersAndOperPlusMinus();
            Console.WriteLine(right+"  "+wrong);
            return View("Quiz");
        }

        bool CheckAnswer(int input1, int input2, string operation, int answer)
        {
            int res = 0; ;
            if (operation == "+") res = input1 + input2;
            if (operation == "-") res = input1 + input2;
            return res == answer;
        }

        [HttpPost]
        public IActionResult Result1(int input1, int input2, string operation, int answer)
        {
            if (CheckAnswer(input1, input2, operation, answer)) right++;
            else wrong++;
            ViewBag.results = result;
            ViewBag.allquestion = (wrong+right);
            ViewBag.right = right;
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
