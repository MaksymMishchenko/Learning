using System;
using System.Collections.Generic;
using System.Threading.Channels;

namespace SumEvenNumbersArrayApp
{
    public class MyArray
    {
        public int[] CreateArray(int elem)
        {
            return new int[elem];
        }

        public int[] FillsArray(int[] arr)
        {
            Random rand = new Random();

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next(1, 100);
            }

            return arr;
        }

        public int SumEvenNumbers(int[] arr)
        {
            int sumEvenNumbers = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    sumEvenNumbers += arr[i];
                }
            }

            return sumEvenNumbers;
        }

        public void Print(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"{arr[i]} \t");
            }

            Console.WriteLine();
        }
    }
}
