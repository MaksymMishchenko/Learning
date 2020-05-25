using System;

namespace CalculatorProgram
{
    class Program
    {
        static void Main()
        {
            double operand1 = 12, operand2 = 3, result = 0;

            Console.WriteLine("Enter the sign of the arithmetic operation: '+', '-', '*', '/', '%'");

            string sign = Console.ReadLine();

            switch (sign)
            {
                case "+":
                {
                    result = operand1 + operand2;
                    break;
                }
                case "-":
                {
                    result = operand1 - operand2;
                    break;
                }
                case "*":
                {
                    result = operand1 * operand2;
                    break;
                }
                case "/":
                {
                        if (operand2 == 0)
                        {
                            Console.WriteLine("Сannot be divided by zero! Enter a value greater than 0 in operand2");
                        }
                        else
                        {
                            result = operand1 / operand2;
                        }
                        break;
                    }
                case "%":
                {
                    result = operand1 % operand2;
                    break;
                }
                default:
                {
                    Console.WriteLine("Such an arithmetic operation does not exist!");
                    break;
                }
            }
            Console.WriteLine("The result of your arithmetic operation:" + result);
            Console.ReadKey();
        }
    }
}
