using System;

namespace ArrayInversionApp
{
    public class MyArray
    {

        public int[] Create(int elem)
        {
            return new int[elem];
        }

        public int[] FillArray(int[] arr, int currentElement)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = currentElement--;
            }

            return arr;
        }

        public int[] InversionArray(int[] arr)
        {
            int temp = 0;
            for (int i = arr.Length - 1, j = 0; i >= arr.Length / 2; i--, j++)
            {
                if (arr[i] > arr[j])
                {
                    temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
                else
                {
                    temp = arr[j];
                    arr[j] = arr[i];
                    arr[i] = temp;
                }
            }

            return arr;
        }

        public void Show(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"{arr[i]} ");
            }

            Console.WriteLine();
        }
    }
}
