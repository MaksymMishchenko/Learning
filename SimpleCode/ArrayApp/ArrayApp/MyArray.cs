using System;

namespace ArrayApp
{
    public class MyArray
    {
        public int[] CreateUserArray(int elements)
        {
            return new int[elements];
        }

        public void FillsUserData(int[] arr, int currentUserData)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = currentUserData;
                currentUserData++;
            }
        }
        public void Print(int[] arr)
        {
            Console.WriteLine($"Массив состоит из: {arr.Length} элементов.");

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine($"Под элементом - {i} находится значение: {arr[i]}");
            }
        }
    }
}
