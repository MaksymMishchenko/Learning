using System;

namespace ArrayPractice
{
    class Program
    {
        private static int[] CreateArray(int elOfNumbers)
        {
            int[] newArray = new int[elOfNumbers];
            return newArray;
        }

        private static void FillArray(int[] arr)
        {
            var rand = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next(1, 100);
            }
        }

        private static void ShowArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"{arr[i]} \t"); 
            }
        }

        static void Main(string[] args)
        {
            var arr = CreateArray(10);
            FillArray(arr);
            ShowArray(arr);
        }
    }
}
