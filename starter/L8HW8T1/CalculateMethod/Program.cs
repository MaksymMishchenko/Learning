using System;

namespace CalculateMethod
{
    class Program
    {
        static void Calculate(ref int value1, ref int value2, ref int value3)
        {
            value1 /= 5;
            value2 /= 5;
            value3 /= 5;
        }

        static void Main()
        {
            int number1 = 10;
            int number2 = 20;
            int number3 = 30;
            Calculate(ref number1, ref number2, ref number3);
            
            Console.WriteLine("Значение первого, второго и третьего аргумента - {0}, {1}, {2}", number1, number2, number3);

            Console.ReadKey();
        }
    }
}
