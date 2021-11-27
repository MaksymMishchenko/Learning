using System;

namespace ArrayApp
{
    public class MyArray
    {
        private readonly IConsole _console;
        public MyArray(IConsole console)
        {
            _console = console;
        }

        public int[] CreateUserArray(int elements)
        {
            return new int[elements];
        }

        public int[] FillsUserData(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine();
                Console.Write($"Введите элемент массива под индексом {i}:\t");
                arr[i] = Int32.Parse(Console.ReadLine());
            }

            return arr;
        }

        public void Show(int num)
        {
            _console.Write(num);
        }
    }
}
