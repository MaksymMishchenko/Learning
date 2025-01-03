using System;

namespace ColorTimeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Now);
            
            do
            {
                Console.WriteLine("Введите цвет времени: r-красный, y-желтый, g-зеленый");
                string color = Console.ReadLine();
                var colors = new Color();
                colors.ChangeColor(color);

            }

            while (!(Console.ReadKey().Key == ConsoleKey.Q));
        }
    }
}