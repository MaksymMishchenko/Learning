using System;

namespace MethodsApp
{
    public class ArrayMethods
    {
        public int[] CreateArray()
        {
            return new int[10];
        }

        public void FillsArray(int[] arr)
        {
            Random rand = new Random();

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next(5);
            }
        }

        public int IndexOf(int[] arr, int findNumber)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == findNumber)
                {
                    return i;
                }
            }

            return -1;
        }

        public void IsNotFound(int index)
        {
            if (index == -1)
            {
                Console.WriteLine("Указанного числа в массиве не найдено!");
            }
            else
            {
                Console.WriteLine($"Число 1 находится под индексом - {index}");
            }
        }

        public void Show(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"{arr[i]}\t");
            }

            Console.WriteLine();
        }
    }
}
