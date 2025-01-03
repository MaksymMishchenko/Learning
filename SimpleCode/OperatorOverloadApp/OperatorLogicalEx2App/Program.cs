using System;

namespace OperatorLogicalEx2App
{
    class Program
    {
        static void Main(string[] args)
        {
            Point a = new Point(5, 6);
            Point b = new Point(10, 10);
            Point с = new Point(0, 0);

            Console.Write("Координаты точки a: ");
            a.Show();

            Console.Write("Координаты точки b: ");
            b.Show();

            Console.Write("Координаты точки с: ");
            с.Show();

            Console.WriteLine();

            if (a) Console.WriteLine("Точка а истинна.");
            if (b) Console.WriteLine("Точка b истинна.");
            if (с) Console.WriteLine("Точка с истинна.");
            if (!a) Console.WriteLine("Точка а ложна.");
            if (!b) Console.WriteLine("Точка b ложна.");
            if (!с) Console.WriteLine("Точка с ложна.");

            Console.WriteLine();

            Console.WriteLine("Применение логических операторов & и |");
            if (a & b) Console.WriteLine("а & b истинно.");
            else Console.WriteLine("а & b ложно.");

            if (a & с) Console.WriteLine("а & с истинно.");
            else Console.WriteLine("а & с ложно.");

            if (a | b) Console.WriteLine("a | b истинно.");
            else Console.WriteLine("а | b ложно.");

            if (a | с) Console.WriteLine("а | с истинно.");
            else Console.WriteLine("а | с ложно.");

            Console.WriteLine();

            // А теперь применить укороченные логические операторы.
            Console.WriteLine("Применение укороченных" +
                              "логических операторов && и ||");

            if (a && b) Console.WriteLine("a && b истинно.");
            else Console.WriteLine("а && b ложно."); 
            if (a && с) Console.WriteLine("а && с истинно.");
            else Console.WriteLine("a && с ложно.");
            if (a || b) Console.WriteLine("a || b истинно.");
            else Console.WriteLine("a || b ложно.");
            if (a || с) Console.WriteLine("a || с истинно.");
            else Console.WriteLine("a || с ложно.");
        }
    }
}
