using System;
using ArithmeticCalculatorApp.Model;

namespace ArithmeticCalculatorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            double operandA = 21;
            double operandB = 2;

            var calc = new Calculator();
            var userData = new Data(operandA,operandB);
            
            string operation = "*";

            var oper = new Calculator();

            switch (operation)
            {
                case "+":
                {
                    calc.Adds(operandA, operandB);
                    break;
                }

                case "-":
                {
                    break;
                }

                case "*":
                {
                    break;
                }

                case "/":
                {
                    break;
                }

                case "%":
                {
                    break;
                }
                default:
                {
                    Console.WriteLine("Такой арифметической операции не существует");
                    break;
                }

            }
        }
    }
}