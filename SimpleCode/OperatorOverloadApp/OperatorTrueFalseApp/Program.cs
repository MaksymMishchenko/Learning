using System;

namespace OperatorTrueFalseApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Point a = new Point(1, 1);
            Point b = new Point(0, 2);
            
            if(a) Console.WriteLine("Истина");
            if(b) Console.WriteLine("Истина");

            Point c = new Point(0, 0);
            if (c) Console.WriteLine("Истина");
            else Console.WriteLine("Fake");
        }
    }
}
