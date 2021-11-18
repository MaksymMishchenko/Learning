using System;

namespace ArrayApp
{
    public class ArrayMethods
    {
        public int[] CreateArray(int elOfArray) => new int[elOfArray];
        
        public int[] FillArray(int[] arr, int from, int till)
        {
            var rand = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next(from, till);
            }

            return arr;
        }

        public int[] SortArray(int[] arr)
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

            return arr;
        }
    }
}
