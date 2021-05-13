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
        public IActionResult Result()
        {
            ViewBag.results = result;
            ViewBag.allquestion = (wrong + right);
            ViewBag.right = right;
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
        public IActionResult Next(int input1, int input2, string operation, string answer)
        {
            if (CheckAnswer(input1, input2, operation, answer)) right++;
            else wrong++;
            result.Add($"{input1} {operation} {input2} = {answer}");
            GenerateInputNumbersAndOperPlusMinus();
            return View("Quiz");
        }

        bool CheckAnswer(int input1, int input2, string operation, string answer)
        {
            int res = 0; ;
            if (operation == "+") res = input1 + input2;
            if (operation == "-") res = input1 - input2;
            return res.ToString() == answer;
        }

        [HttpPost]
        public IActionResult Result1(int input1, int input2, string operation, string answer)
        {
            if (CheckAnswer(input1, input2, operation, answer)) right++;
            else wrong++;
            result.Add($"{input1} {operation} {input2} = {answer}");
            ViewBag.results = result;
            ViewBag.allquestion = (wrong+right);
            ViewBag.right = right;
            return View("Result");
        }

    }
}
