using System;
using OperatorExplicitApp;

namespace OperatorExplicitToIntApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Digit digit = new Digit(2, 3);
            int i;

            i = (int)digit;

            Console.WriteLine(i);
        }
    }
}
