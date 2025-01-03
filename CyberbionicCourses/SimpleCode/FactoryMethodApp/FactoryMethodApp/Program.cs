using System;

namespace FactoryMethodApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var r1 = new Rectangle(4, 5);
            r1.Show();
            int r1Area = r1.GetArea();
            Console.WriteLine($"Rectangle Area: {r1Area}");

            Console.WriteLine(new string('-', 50));

            var r2 = r1.Factor(2);
            r2.Show();
            int r2Area =  r2.GetArea();
            Console.WriteLine($"Rectangle Area with Factor: {r2Area}");
        }
    }
}
