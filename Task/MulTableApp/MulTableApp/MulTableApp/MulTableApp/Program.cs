using System;

namespace MulTableApp
{
    class Program
    {
        static void Main()
        {
            string[] str = {
                "2 *  1 =  2", 
                "2 *  2 =  4", 
                "2 *  3 =  6", 
                "2 *  4 =  8", 
                "2 *  5 = 10", 
                "2 *  6 = 12", 
                "2 *  7 = 14", 
                "2 *  8 = 16", 
                "2 *  9 = 18", 
                "2 * 10 = 20"
            };

            BuildTable(str);
        }
        public static void BuildTable(string[] str)
        {
            // левый верхний
            Console.Write($"{(char)9556}");

            // выводим верхнюю горизонталь таблицы
            for (int j = 0; j < str.Length+1; j++)
            {
                Console.Write($"{(char) 9552}");
            }

            // выводим правый верхний угол таблицы
            Console.WriteLine($"{(char) 9559}");

            // строка помещенная в таблицу
            foreach (var elem in str)
            {
                Console.Write($"{(char)9553}");
                Console.Write(elem);
                Console.WriteLine($"{(char)9553}");
                //Console.Write(" ");
            }

            // выводим левый нижний угол таблицы
            Console.Write($"{(char)9562}");

            // выводим нижнюю горизонталь таблицы
            for (int j = 0; j < str.Length + 1; j++)
            {
                Console.Write($"{(char)9552}");
            }
            Console.Write($"{(char)9565}");
        }
    }
}