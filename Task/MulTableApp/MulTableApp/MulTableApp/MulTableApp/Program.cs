using System;

namespace MulTableApp
{
    class Program
    {
        static void Main()
        {
            string[] firstColumn = {
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

            string[] secondColumn = {
                "3 *  1 =  3",
                "3 *  2 =  6",
                "3 *  3 =  9",
                "3 *  4 = 12",
                "3 *  5 = 15",
                "3 *  6 = 18",
                "3 *  7 = 21",
                "3 *  8 = 24",
                "3 *  9 = 27",
                "3 * 10 = 30"
            };
            BuildTable(firstColumn, secondColumn);
        }

        public static void BuildTable(string[] arr1, string[] arr2)
        {
            // левый верхний
            Console.Write($"{(char)9556}");

            // выводим верхнюю горизонталь таблицы
            for (int j = 1; j < arr1.Length+arr2.Length+6; j++)
            {
                Console.Write($"{(char) 9552}");
            }

            // выводим правый верхний угол таблицы
            Console.WriteLine($"{(char) 9559}");

            // данные помещенная в таблицу
            for (int i = 1; i < arr1.Length; i++)
            {
                Console.Write($"{(char)9553}");
                Console.Write($"{arr1[i]} {(char)9474} {arr2[i]}");
                Console.WriteLine($"{(char)9553}");

                //Console.WriteLine($" {(char)9474}");
            }

            // выводим левый нижний угол таблицы
            Console.Write($"{(char)9562}");

            // выводим нижнюю горизонталь таблицы
            for (int j = 0; j < arr1.Length+arr2.Length+5; j++)
            {
                Console.Write($"{(char)9552}");
            }
            Console.Write($"{(char)9565}");
        }
    }
}