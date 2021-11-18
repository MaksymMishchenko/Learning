using System;
using System.Collections.Generic;

namespace ArrayPracticeOneApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = CreateArray(10);
            FillArray(arr);
            Show(arr);

            var delArr = RemovesElements(arr, 3);
            Show(delArr);
        }

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
                arr[i] = rand.Next(1, 5);
            }
        }

        private static int[] RemovesElements(int[] arr, int number)
        {
            List<int> arrayAfterDeletion = new List<int>();

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] != number)
                {
                    arrayAfterDeletion.Add(arr[i]);
                }
            }
            return arrayAfterDeletion.ToArray();
        }

        private static void Show(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"{arr[i]} \t");
            }

            Console.WriteLine();
        }
    }
}
