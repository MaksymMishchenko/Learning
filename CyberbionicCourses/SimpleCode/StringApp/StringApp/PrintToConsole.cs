using System;

namespace StringApp
{
    class PrintToConsole : IPrintToConsole
    {
        public void Print(string[] arrString, int[] arr, int index)
        {
            for (; index >= 0; index--)
            {
                Console.Write($"{arrString[arr[index]]}|");
            }
        }
    }
}