using System;
using System.Runtime.InteropServices;

namespace RefArrayApp
{
    class Program
    {
        static void Resize<T>(ref T[] arr, int newSize)
        {
            T[] newArray = new T[newSize];

            for (int i = 0; i < arr.Length && i < newArray.Length; i++)
            {
                newArray[i] = arr[i];
            }
            arr = newArray;
        }

        static void PrintArray<T>(T[] arr)
        {
            foreach (var el in arr)
            {
                Console.Write($"{el}\t");
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            // массив int
            int[] arr = { 1, 2, 3 };
            Console.WriteLine($"Размер массива (int) до увеличения: {arr.Length}");
            PrintArray(arr);

            Resize(ref arr, 7);
            Console.WriteLine($"Размер массива (int) после увеличения: {arr.Length}");
            PrintArray(arr);

            Resize(ref arr, 2);
            Console.WriteLine($"Размер массива (int) после уменьшения: {arr.Length}");
            PrintArray(arr);

            Console.WriteLine(new string('-', 50));

            // массив string
            string[] stringArr = { "One", "Two", "Three" };

            Console.WriteLine($"Размер массива (string) до увеличения: {stringArr.Length}");
            PrintArray(stringArr);

            Resize(ref stringArr, 7);
            Console.WriteLine($"Размер массива (string) после увеличения: {stringArr.Length}");
            PrintArray(stringArr);

            Resize(ref stringArr, 2);
            Console.WriteLine($"Размер массива (string) после уменьшения: {stringArr.Length}");
            PrintArray(stringArr);
        }
    }
}
