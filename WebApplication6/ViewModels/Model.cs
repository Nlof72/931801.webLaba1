using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication6.ViewModels
{
    public class CalcOperation
    {
        public int input1 { get; set; }
        public int input2 { get; set; }
        public string operation { get; set; }

        public CalcOperation() { }
        public CalcOperation(int inp1, int inp2, string oper)
        {
            input1 = inp1;
            input2 = inp2;
            operation = oper;
        }
        public string Calc()
        {
            string res = "";
            if (operation == "+") { res = (input1 + input2).ToString(); }
            if (operation == "-") { res = (input1 - input2).ToString(); }
            if (operation == "*") { res = (input1 * input2).ToString(); }
            if (operation == "/")
            {
                if (input2 == 0) res = "divider is eaquel 0";
                else res = ((double)input1 / input2).ToString();
            }
            return res;
        }
    }
}
