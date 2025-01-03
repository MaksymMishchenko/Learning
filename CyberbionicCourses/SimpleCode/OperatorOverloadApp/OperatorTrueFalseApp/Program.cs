using System;

namespace OperatorTrueFalseApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Point a = new Point(1, 1);
            Point b = new Point(0, 2);

            if (a) Console.WriteLine("True");
            if (b) Console.WriteLine("True");

            Point c = new Point(0, 0);
            if (c) Console.WriteLine("True");
            else Console.WriteLine("False");

            Point d = new Point(4, 4);
            do
            {
                d.Show();
                --d;
            } while (d);

            if (d)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("False");
            }

        }
    }
}
