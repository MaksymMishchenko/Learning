using System;

namespace TableApp
{
    class Program
    {
        static void Main()
        {
            Table table = new Table(new File());
            string str = table.PrintOnScreen();

            table.Save("array.txt");

            Console.WriteLine(str);
            Console.ReadKey();
        }
    }
}
