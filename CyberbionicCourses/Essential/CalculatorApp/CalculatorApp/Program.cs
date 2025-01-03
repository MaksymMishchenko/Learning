using System;

namespace CalculatorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            ArithDelegate sum = (int a, int b) => a + b;
            ArithDelegate sub = (int a, int b) => a - b;
            ArithDelegate mul = (int a, int b) => a * b;
            ArithDelegate div = (int a, int b) => IsZero(a) ? 0: a / b;

            Console.WriteLine("Input first digit: ");
            int digitA = int.Parse(Console.ReadLine());

            Console.WriteLine("Input operations: '+', '-', '*', '/'");
            string operation = Console.ReadLine();

            Console.WriteLine("Input second digit: ");
            int digitB = int.Parse(Console.ReadLine());

            switch (operation)
            {
                case "+":
                    Console.WriteLine("Operation result: ");
                    Console.WriteLine(sum.Invoke(digitA, digitB));
                    break;
                case "-":
                    Console.WriteLine("Operation result: ");
                    Console.WriteLine(sub.Invoke(digitA, digitB));
                    break;
                case "*":
                    Console.WriteLine("Operation result: ");
                    Console.WriteLine(mul.Invoke(digitA, digitB));
                    break;
                case "/":
                    Console.WriteLine("Operation result: ");

                    Console.WriteLine(div.Invoke(digitA, digitB));
                    break;
                default:
                    Console.WriteLine("Incorrect operation. Please, try again");
                    break;
            }
        }

        private static bool IsZero(int digitA)
        {
            if (digitA == 0)
                Console.WriteLine("На нуль делить нельзя");
            return false;
        }
    }
}
