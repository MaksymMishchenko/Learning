using System;

namespace ArrayPractice
{
    class Program
    {
        /// <summary>
        /// Сreates a one-dimensional array
        /// </summary>
        /// <param name="elOfNumbers"></param>
        /// <returns>Returns new array</returns>
        private static int[] CreateArray(int elOfNumbers)
        {
            int[] newArray = new int[elOfNumbers];
            return newArray;
        }

        /// <summary>
        /// Fills the array positive numbers with random values
        /// </summary>
        /// <param name="arr"></param>
        private static void FillArrayPositiveNumbers(int[] arr)
        {
            var rand = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next(1, 100);
            }
        }

        /// <summary>
        /// Fills the array positive and negative numbers with random values
        /// </summary>
        /// <param name="arr"></param>
        private static void FillArrayPosNegNumbers(int[] arr)
        {
            var rand = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next(-50, 50);
            }
        }

        /// <summary>
        /// Sorts items from smallest to largest
        /// </summary>
        /// <param name="arr"></param>
        private static void SortArray(int[] arr)
        {
            int temp = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
        }

        private static void ChangeNegativeToPositiveNumbers(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < 0)
                {
                    arr[i] = -arr[i];
                }
            }
        }

        /// <summary>
        /// Displays array elements to the screen
        /// </summary>
        /// <param name="arr"></param>
        private static void ShowArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"{arr[i]} \t");
            }

            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            var arr = CreateArray(10);
            FillArrayPositiveNumbers(arr);

            Console.WriteLine(" Random Fill array positive numbers:");
            ShowArray(arr);
            Console.WriteLine(new string('-', 75));

            SortArray(arr);
            Console.WriteLine("Sorted array:");
            ShowArray(arr);
            Console.WriteLine(new string('-', 75));

            FillArrayPosNegNumbers(arr);
            SortArray(arr);
            Console.WriteLine("Sorted array:");
            ShowArray(arr);
            ChangeNegativeToPositiveNumbers(arr);
            Console.WriteLine("Fills array positive and negative numbers:");
            ShowArray(arr);
        }
    }
}
