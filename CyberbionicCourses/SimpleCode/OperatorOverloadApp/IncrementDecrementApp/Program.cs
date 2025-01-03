using System;
using OperatorOverloadApp;

namespace IncrementDecrementApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Point a = new Point(0, 0);

            Console.WriteLine("a   ={0}", a);
            Console.WriteLine("a++ ={0}", a++);
            Console.WriteLine("a   ={0}", a);

            Console.WriteLine("a-- ={0}", a--);
            Console.WriteLine("a   ={0}", a);

            Console.WriteLine("++a ={0}", ++a);
            Console.WriteLine("a   ={0}", a);

            Console.WriteLine("--a ={0}", --a);
            Console.WriteLine("a   ={0}", a);
        }
    }
}
