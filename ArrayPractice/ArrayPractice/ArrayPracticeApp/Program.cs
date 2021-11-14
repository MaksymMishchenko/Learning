using System;

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
        private static void GetEvenNumbers(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    Console.Write($"{arr[i]} \t");
                }
            }
            Console.WriteLine();
        }

        /// <summary>
        /// Displays all elements of the array after 1.
        /// </summary>
        /// <param name="arr"></param>
        private static void GetOddIndexOfArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write($"{arr[i]} \t");
                }
            }

            Console.WriteLine();
        }

        /// <summary>
        /// Outputs all elements of an array until element -1 is encountered.
        /// </summary>
        /// <param name="arr"></param>
        private static void GetElementsOfArrayIfNotMinusOne(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] != -1)
                {
                    Console.Write($"{arr[i]} \t");
                }
                else
                {
                    break;
                }
            }
            Console.WriteLine();
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

        static void Main(string[] args)
        {
            var arr = CreateArray();
            Console.WriteLine("All elements of array: ");
            Show(arr);

            Console.WriteLine("Reverse elements of array: ");
            ReverseArray(arr);
            Show(arr);

            Console.WriteLine("Even numbers of array: ");
            GetEvenNumbers(arr);

            Console.WriteLine("Print an array through 1 element: ");
            GetOddIndexOfArray(arr);

            Console.WriteLine("Print elements of array if element not -1: ");
            GetElementsOfArrayIfNotMinusOne(arr);

        }
    }
}
