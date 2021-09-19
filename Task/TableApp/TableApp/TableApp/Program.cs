using System;

namespace TableApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Table data = new Table(1990, 1991, 1992, 1993, 135, 7290, 11300, 16200);
            data.PrintOnScreen();

            Console.ReadKey();
        }
    }
}
