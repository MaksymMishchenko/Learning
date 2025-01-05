using System;

namespace RemoveAtArrayApp
{
    class Program
    {
        static void RemoveAt(ref int[] arr, int index)
        {
            int[] newArray = new int[arr.Length - 1];

            for (int i = 0; i < index; i++)
            {
                newArray[i] = arr[i];
            }

            for (int i = index+1; i < arr.Length; i++)
            {
                newArray[i-1] = arr[i];
            }

            arr = newArray;
        }

        static void RemoveFirst(ref int[] arr)
        {
            RemoveAt(ref arr, 0);
        }

        static void RemoveLast(ref int[] arr)
        {
            RemoveAt(ref arr, arr.Length-1);
        }

        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5, 6 };
            RemoveAt(ref arr, 3);
            RemoveFirst(ref arr);
            RemoveLast(ref arr);
        }
    }
}
