using System;

namespace RecursionSumArrayApp
{
    class Program
    {
        static int Sum(int[] arr, int i = 0)
        {
            if (i >= arr.Length)
            {
                return 0;
            }

            return arr[i] + Sum(arr, i + 1);
        }

        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 6, 8 };

            var result = Sum(arr);
            Console.WriteLine(result);
        }
    }
}
