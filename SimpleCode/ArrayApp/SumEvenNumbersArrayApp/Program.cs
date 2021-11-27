using System;
using System.Runtime.InteropServices;

namespace SumEvenNumbersArrayApp
{
    class Program
    {
        static void Main(string[] args)
        {
            MyArray arr = new MyArray();

            int numberOfElements = 6;
            var newArray = arr.CreateArray(numberOfElements);
            arr.FillsArray(newArray);

            Console.WriteLine("Массив случайно заполненных чисел: ");
            arr.Print(newArray);

            var sumEvenNumbers = arr.SumEvenNumbers(newArray);
            Console.WriteLine($"Сумма четных чисел массива: {sumEvenNumbers}");
            


        }
    }
}
