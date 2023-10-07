using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace practice07._10.Services
{
    internal class CalculateService
    {
       
        public string Calculate(double num1, double num2, string operation)
        {
            string result;

            switch (operation)
            {
                case "+":
                    result = (num1 + num2).ToString();
                    return result;
                case "-":
                    result = (num1 - num2).ToString();
                    return result;
                case "*":
                    result = (num1 * num2).ToString();
                    return result;
                case "/":
                    result = (num1 / num2).ToString();
                    return result;
                default:
                    result = "Operation invalid";
                    return result;

            }
        }

    }
}
