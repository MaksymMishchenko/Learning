using System;
using OperatorOverloadApp;

namespace EqualNotEqualApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Point a = new Point(1, 1);
            Point b = new Point(2, 2);

            Console.WriteLine("a равно б: {0}", a==b);
            Console.WriteLine("a не равно б: {0}", a!=b);

            Point c = new Point(1, 1);

            Console.WriteLine("a равно c: {0}", a == c);
            Console.WriteLine("a не равно c: {0}", a != c);
        }
    }
}
