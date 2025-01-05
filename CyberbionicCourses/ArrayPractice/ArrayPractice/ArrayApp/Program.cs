using System;

namespace ArrayApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var arrMethods = new ArrayMethods();
            var print = new PrintOnScreen();

            var arr = arrMethods.CreateArray(10);
            arrMethods.FillArray(arr, 1, 100);

            Console.WriteLine("Несортированный массив: ");
            print.Show(arr);
            
            Console.WriteLine("Сортированный массив: ");
            arrMethods.SortArray(arr);
            print.Show(arr);
        }
    }
}
