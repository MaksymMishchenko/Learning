﻿using System;

namespace ArrayApp
{
    public interface IConsole
    {
        void Print(in int[] arr);
    }
    public class ConsoleWrapper : IConsole
    {
        public void Print(in int[] arr)
        {
            Console.WriteLine();
            Console.WriteLine($"Массив состоит из: {arr.Length} элементов.");
            Console.WriteLine(new string('-', 50));
           
           for (int i = 0; i < arr.Length; i++)
           {
               Console.WriteLine($"Под элементом - {i} находится значение: {arr[i]}");
           }
        }
    }
}
