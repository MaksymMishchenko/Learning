using System;

namespace MulTableApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // вызываем метод и в качестве параметра передаем 2
            BuildTable("2");
        }

        public static void BuildTable(string str)
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

            // преобразуем string в int
            var number = int.Parse(str);
            // результат вычисления помещенный в таблицу
            for (int i = 2; i <= number; i++) 
            {
                for (int j = 2; j <= i; j++)
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
