using System;
using System.ComponentModel;

namespace AverageArithmeticApp
{
    class Program
    {
        static void Main(string[] args)
        {
           MyDelegate arithOperation = delegate(int a, int b, int c)
            {
                return (a + b + c) / 3;
            };
           int result = arithOperation.Invoke(2, 3, 4);
           Console.WriteLine(result);
        }
    }
}
