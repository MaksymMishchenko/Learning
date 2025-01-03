using System;

namespace OperatorOverloadApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Point a = new Point(1, 1);
            Point b = new Point(2, 2);
            
            Console.WriteLine("a + b = {0}", a + b);
            Console.WriteLine("a - b = {0}", a - b);
            Console.WriteLine("a * b = {0}", a * b);
            Console.WriteLine("a / b = {0}", a / b);

            Point c = new Point(0, 0);
            c += a;
            Console.WriteLine("c + a = {0}", c);

            Point d = new Point(3, 3);
            Point f = new Point(4, 4);

            Point.Add(d, f);
            Point.Subtract(d, f);
        }
    }
}
