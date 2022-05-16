using System;
using System.Collections;

namespace SquareOddDigitApp
{
    class Program
    {
        private static IEnumerable GetCollection(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 != 0)
                {
                    yield return array[i] * array[i];
                }
            }
        }

        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };

            foreach (var item in GetCollection(arr))
            {
                Console.Write($"{item} ");
            }
        }
    }
}
