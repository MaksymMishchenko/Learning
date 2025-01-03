using System;
using System.Threading.Channels;

namespace ColorTimeApp
{
    class Color
    {
        public void ChangeColor(string color)
        {
            switch (color)
            {
                case "r":
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Вы выбрали красный цвет");
                    Console.WriteLine(DateTime.Now);
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    break;
                }

                case "y":
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Вы выбрали желтый цвет");
                        Console.WriteLine(DateTime.Now);
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    break;
                }

                case "g":
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Вы выбрали зеленый цвет");
                        Console.WriteLine(DateTime.Now);
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    break;
                }
                default:
                    Console.WriteLine("Вы ввели неверную букву");
                    break;
            }
        }
    }
}
