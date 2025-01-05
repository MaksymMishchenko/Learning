using System;

namespace ArrayApp
{
    public class MyArray
    {
       public int[] CreateUserArray(int elements)
        {
            return new int[elements];
        }

        public void FillsUserData(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine();
                Console.Write($"Введите значение под индексом - {i}: ");
                arr[i] = Int32.Parse(Console.ReadLine());
            }
        }

        public void Show(int[] arr)
        {
            foreach (var el in arr)
            {
                Console.Write($"{el}\t");
            }
        }
    }
}
