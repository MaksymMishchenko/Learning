using System;
using ArrayInversionApp;

namespace ArrayInversionApp
{
    class Program
    {
        static void Main(string[] args)
        {


            MyArray arr = new MyArray();
            var array = arr.Create(10);
            arr.FillArray(array, 10);
            arr.Show(array);

            Console.WriteLine(new string('-', 50));

            arr.InversionArray(array);
            arr.Show(array);
        }
    }
}
