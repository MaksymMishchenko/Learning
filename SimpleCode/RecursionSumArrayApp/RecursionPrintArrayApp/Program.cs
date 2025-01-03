using System;

namespace RecursionPrintArrayApp
{
    class Program
    {
        private static void PrintArray(int[] arr, int i = 0)
        {
            if (i < arr.Length)
            {
                Console.WriteLine(arr[i]);
                PrintArray(arr, i + 1);
            }
        }
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            PrintArray(arr);
        }
    }
}
