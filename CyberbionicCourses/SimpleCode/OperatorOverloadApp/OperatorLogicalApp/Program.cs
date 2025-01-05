using System;

namespace OperatorLogicalApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Point a = new Point(1, 1);
            Point b = new Point(2, 2);
            Point c = new Point(0, 0);

            Console.WriteLine("Координаты точки A: ");
            a.Show();
            Console.WriteLine("Координаты точки B: ");
            b.Show();
            Console.WriteLine("Координаты точки C: ");
            c.Show();

            if(!a) Console.WriteLine("Точка а ложна!");
            else Console.WriteLine("false");

            if (!b) Console.WriteLine("Точка b ложна!");
            else Console.WriteLine("false");

            if (!c) Console.WriteLine("Точка c ложна!");
            else Console.WriteLine("false");

            if (a & b) Console.WriteLine("a & b истинно.");
            else Console.WriteLine("a & b ложно.");

            if (a & c) Console.WriteLine("a & с истинно.");
            else Console.WriteLine("a & с ложно.");

            if (a | b) Console.WriteLine("a | b истинно.");
            else Console.WriteLine("a | b ложно.");

            if (a | c) Console.WriteLine("a | c истинно.");
            else Console.WriteLine("a | c ложно.");
        }
    }
}
