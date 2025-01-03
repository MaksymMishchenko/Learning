using System;

namespace ArrayPracticeTwoApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = CreateArray(10);
            FillArray(arr);
            Show(arr);

            var newArray = AddElementToArray(arr, 5);
            Show(newArray);
        }

        private static int[] CreateArray(int elOfNumbers)
        {
            int[] newArr = new int[elOfNumbers];
            return newArr;
        }

        private static void FillArray(int[] arr)
        {
            var rand = new Random();

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next(1, 5);
            }
        }

        private static int[] AddElementToArray(int[] arr, int number)
        {
           int[] newArray = new int[arr.Length+1];

            for (int i = 0; i < newArray.Length-1; i++)
            {
                newArray[i] = arr[i];
            }

            for (int i = 0; i < newArray.Length; i++)
            {
                if (newArray[i] == 0)
                {
                    newArray[i] = number;
                }
            }

            return newArray;
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
