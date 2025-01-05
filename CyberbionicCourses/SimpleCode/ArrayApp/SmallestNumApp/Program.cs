using System;

namespace SmallestNumApp
{
    class Program
    {
        static void Main(string[] args)
        {
            MyArray arr = new MyArray();
            var newArr = arr.CreateArray(10);
            arr.FillArray(newArr);
            arr.Show(newArr);

            int min = arr.GetSmallestNumeric(newArr);
            Console.WriteLine(min);

        }
    }
}
