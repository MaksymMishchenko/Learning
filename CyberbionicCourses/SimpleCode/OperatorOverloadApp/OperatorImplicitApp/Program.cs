using System;

namespace OperatorImplicitApp
{
    class Program
    {
        static void Main(string[] args)
        {
            byte argument = 1;

            // неявное преобразование byte-to-Digit
            Digit digit = argument;

            Console.WriteLine(digit);
        }
    }
}
