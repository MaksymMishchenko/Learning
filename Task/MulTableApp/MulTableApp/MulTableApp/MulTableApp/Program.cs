using System;

namespace MulTableApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // выводим левый верхний угол таблицы
            Console.Write($"{(char)9556}");

            // выводим верхнюю горизонталь таблицы
            for (int j = 0; j < 9; j++)
            {
                Console.Write($"{(char)9552}");
            }

            // выводим правый верхний угол таблицы
            Console.WriteLine($"{(char)9559}");

            // выводим левую вертикаль таблицы
            for (int j = 0; j < 1; j++)
            {
                Console.Write($"{(char)9553}");
            }

            // результат вычисления помещенный в таблицу
            for (int i = 2; i <= 2; i++)
            {
                for (int j = 2; j <= 2; j++)
                {
                    var result = i * j;
                    Console.Write($"{i} * {j} = {result}");
                }
            }
            // выводим правую вертикаль таблицы
            Console.Write($"{(char)9553}");

            // переводим курсор на новую строку
            Console.WriteLine();

            // выводим левый нижний угол таблицы
            Console.Write($"{(char)9562}");

            // выводим нижнюю горизонталь таблицы
            for (int j = 0; j < 9; j++)
            {
                Console.Write($"{(char)9552}");
            }
            Console.Write($"{(char)9565}");
        }
    }
}
