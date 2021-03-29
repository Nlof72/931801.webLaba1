using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication6.Services
{
    public class Calc
    {
        public Calc()
        {
            Random rand = new Random();
            num1 = rand.Next(0, 10);
            num2 = rand.Next(0, 10);
        }
        public int num1 { get; set; }
        public int num2 { get; set; }
        public string sum()
        {
            return num1 + " + " + num2 + " = " + (num1 + num2);
        }
        public string sub()
        {
            return num1 + " - " + num2 + " = " + (num1 - num2);
        }
        public string mult()
        {
            return num1 + " * " + num2 + " = " + (num1 * num2);
        }
        public string div()
        {
            try { return num1 + " / " + num2 + " = " + (num1 / num2); }
            catch { return "Division by 0"; }

        }
    }
}
