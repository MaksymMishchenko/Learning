using System;

namespace ArrayPracticeThreeApp
{
    class Program
    {
        private static int[] CreateArray(int elementsOfArr)
        {
            return new int[elementsOfArr];
        }

        private static void FillArray(int[] arr)
        {
            var rand = new Random();

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next(1, 10);
            }
        }

        private static void ReverseArray(int[] arr)
        {
            int temp = 0;

            for (int i = 0; i < arr.Length / 2; i++)
            {
                temp = arr[i];
                arr[i] = arr[arr.Length - i - 1];
                arr[arr.Length - i - 1] = temp;
            }
        }

        private static void CountPositiveNegativeNumbers(int[] arr, ref int positive, ref int negative)
        {

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    positive++;
                }
                else
                {
                    negative++;
                }
            }
        }

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
            var arr = CreateArray(10);
            FillArray(arr);

            Console.WriteLine("Массив з рандомно заполненными элементами: ");
            Show(arr);

            ReverseArray(arr);
            Console.WriteLine("Реверс массива: ");
            Show(arr);

            int pos = 0;
            int neg = 0;
            CountPositiveNegativeNumbers(arr, ref pos, ref neg);

            Console.WriteLine($"Позитивных элементов: {pos}, Негативных элементов: {neg}");
        }
    }
}
