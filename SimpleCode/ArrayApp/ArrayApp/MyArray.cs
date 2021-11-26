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

        public int[] FillsUserData(int[] arr, int currentUserData)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = currentUserData;
                currentUserData++;
            }

            return arr;
        }

        public void Show(int[] arr)
        {
            _console.Print(arr);
        }
    }
}
