using System;
using System.Collections.Generic;

namespace ArrayPracticeApp
{
    class Program
    {
        /// <summary>
        /// Сreates a new array of user-defined size.
        /// </summary>
        /// <returns>new array</returns>
        private static int[] CreateArray()
        {
            int[] arr = new int[] { 5, 3, 8, 10, 12, 16, -1, -5, -3, -10 };
            return arr;
        }

        /// <summary>
        /// Displays all the elements of an array in reverse order.
        /// </summary>
        /// <param name="arr"></param>
        private static void ReverseArray(int[] arr)
        {
            int temp = 0;

            for (int i = arr.Length - 1, j = 0; i >= arr.Length / 2; i--, j++)
            {
                if (arr[i] < arr[j])
                {
                    temp = arr[j];
                    arr[j] = arr[i];
                    arr[i] = temp;
                }
            }
        }

        /// <summary>
        /// Outputs even elements of an array.
        /// </summary>
        /// <param name="arr"></param>
        private static List<int> GetEvenNumbers(int[] arr)
        {
            List<int> numbers = new List<int>();

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    numbers.Add(arr[i]);
                }
            }

            return numbers;
        }

        /// <summary>
        /// Displays all elements of the array after 1.
        /// </summary>
        /// <param name="arr"></param>
        private static List<int> GetOddIndexOfArray(int[] arr)
        {
            List<int> numbers = new List<int>();

            for (int i = 0; i < arr.Length; i++)
            {
                if (i % 2 == 0)
                {
                    numbers.Add(arr[i]);
                }
            }

            return numbers;
        }

        /// <summary>
        /// Outputs all elements of an array until element -1 is encountered.
        /// </summary>
        /// <param name="arr"></param>
        private static List<int> GetElementsOfArrayIfNotMinusOne(int[] arr)
        {
            List<int> numbers = new List<int>();

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] != -1)
                {
                    numbers.Add(arr[i]);
                }
                else
                {
                    break;
                }
            }
            return numbers;
        }

        /// <summary>
        /// Print array
        /// </summary>
        /// <param name="arr"></param>
        private static void Show(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"{arr[i]} \t");
            }

            Console.WriteLine();
        }

        private static void ShowCollection(List<int> numList)
        {
            foreach (var el in numList)
            {
                Console.Write($"{el} \t");
                
            }

            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            var arr = CreateArray();
            Console.WriteLine("All elements of array: ");
            Show(arr);

            Console.WriteLine("Reverse elements of array: ");
            ReverseArray(arr);
            Show(arr);

            Console.WriteLine("Even numbers of array: ");
            var evenNumbers = GetEvenNumbers(arr);
            ShowCollection(evenNumbers);
            
            Console.WriteLine("Print an array through 1 element: ");
            var elemOfArray = GetOddIndexOfArray(arr);
            ShowCollection(elemOfArray);
            
            Console.WriteLine("Print elements of array if element not -1: ");
            var printIfNotNegativeOne = GetElementsOfArrayIfNotMinusOne(arr);
            ShowCollection(printIfNotNegativeOne);
        }
    }
}
