using practice07._10.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice07._10.Controllers
{
    internal class CalculateController
    {
        private CalculateService _calculateService;
        public CalculateController() 
        {
        _calculateService= new();
        }

        public void Calculate()
        {
            Console.WriteLine("Add first number");
               Num1: string num1 = Console.ReadLine();

            double number1;

            bool isTrueNum1 = double.TryParse(num1, out number1);

            if (!isTrueNum1)
            {
                Console.WriteLine("Please add correct number ");
                goto Num1;

            }

            Console.WriteLine("Please select one operator: + , - , * , / ");

            string operation = Console.ReadLine();


            Console.WriteLine("Add second number");

        Num2: string num2 = Console.ReadLine();

            double number2;

            bool isTrueNum2= double.TryParse(num2, out number2);

            if (!isTrueNum2)
            {
                Console.WriteLine("Please add correct number");
                goto Num2;
            }
            if (operation == "/"  && number2 == 0)
            {
                Console.WriteLine("Cont be divide by zero, please start again");
                goto Num1;
            }
            string result = _calculateService.Calculate(number1, number2, operation);

            Console.WriteLine(result);
        }
    }
}
