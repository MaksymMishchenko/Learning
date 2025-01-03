using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 8, b = 3, c = 12;
            float result;
            result = (a + b + c) / 3; 
            Console.Write("Среднее арифметическое чисел a, b и c = ");
            Console.WriteLine(result); //потеря точности, выбрал тип данных Float
            Console.ReadKey();

        }
    }
}
