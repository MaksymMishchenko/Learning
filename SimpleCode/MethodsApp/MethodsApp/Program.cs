using System;
using System.Threading.Channels;

namespace MethodsApp
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayMethods arr1 = new ArrayMethods();

            var arr = arr1.CreateArray();
            arr1.FillsArray(arr);
            arr1.Show(arr);
            Console.WriteLine();
            var index = arr1.IndexOf(arr, 1);
            arr1.IsNotFound(index);
        }
    }
}
