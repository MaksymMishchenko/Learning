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
            ArithDelegate div = (int a, int b) => a / b;

            Console.WriteLine(sum.Invoke(2,5));
            Console.WriteLine(sub.Invoke(10, 2));
            Console.WriteLine(mul.Invoke(3,3));
            Console.WriteLine(div.Invoke(10,2));
        }
    }
}
