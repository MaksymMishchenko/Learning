using System;
using System.Threading.Channels;

namespace MulTableApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            // левый верхний
            Console.Write($"{(char)9556}");

            // горизонтальная
            Console.Write($"{(char)9552}");
            Console.Write($"{(char)9552}");
            Console.Write($"{(char)9552}");
            Console.Write($"{(char)9552}");

            // правый верхний
            Console.Write($"{(char)9559}");
            Console.WriteLine();

            // вторая строка
            // вертикальная линия
            Console.Write($"{(char)9553}");
            Console.Write("....");
            Console.Write($"{(char)9553}");
            Console.WriteLine();

            // третья строка
            // левый нижний
            Console.Write($"{(char)9562}");
            Console.Write($"{(char)9552}");
            Console.Write($"{(char)9552}");
            Console.Write($"{(char)9552}");
            Console.Write($"{(char)9552}");
            Console.Write($"{(char)9565}");

        }
    }
}
