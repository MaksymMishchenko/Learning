using System;

namespace SecSmallValueApp
{
    class Program
    {
        static void Main(string[] args)
        {
            MyArray arr = new MyArray();
            var newArray= arr.GetNewArray(12);
            arr.FillsArray(newArray);

            Console.WriteLine("Массив до сортировки: ");
            arr.Show(newArray);

            arr.SortArray(newArray);
            Console.WriteLine("Массив после сортировки: ");
            arr.Show(newArray);

            var result =arr.GetSecondSmallestNumber(newArray);
            Console.WriteLine("Наименьшее второе числов массиве: ");
            Console.WriteLine(result);

        }
    }
}
