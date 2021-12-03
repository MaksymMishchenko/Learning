using System;

namespace InsertToArrayApp
{
    class Program
    {
        static void Insert(ref int[] arr, int value, int index)
        {
            int[] newArray = new int[arr.Length + 1];
            newArray[index] = value;

            for (int i = 0; i < index; i++)
            {
                newArray[i] = arr[i];
            }

            for (int i = index; i < arr.Length; i++)
            {
                newArray[i + 1] = arr[i];
            }

            arr = newArray;
        }

        static void InsertFirst(ref int[] arr, int value)
        {
            Insert(ref arr, value, 0);
        }

        static void InsertLast(ref int[] arr, int value)
        {
            Insert(ref arr, value, arr.Length);
        }

        static void Main(string[] args)
        {
            int[] arr = { 2, 3, 5, 8, 9 };
            Insert(ref arr, 10, 3);
            InsertFirst(ref arr, 1);
            InsertLast(ref arr, 11);
        }
    }
}
