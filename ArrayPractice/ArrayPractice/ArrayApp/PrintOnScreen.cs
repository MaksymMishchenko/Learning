using System;

namespace ArrayApp
{
    class PrintOnScreen : IPrintOnScreen
    {
        public void Show(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"{arr[i]} \t");
            }

            Console.WriteLine();
        }
    }
}
