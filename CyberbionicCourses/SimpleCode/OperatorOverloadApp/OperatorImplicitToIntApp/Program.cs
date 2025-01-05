using System;

namespace OperatorImplicitToIntApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Digit digit = new Digit(5, 4);
            int i;

            i = digit;

            Console.WriteLine(i);
        }
    }
}
