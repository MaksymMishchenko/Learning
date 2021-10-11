using System;
using System.Threading.Channels;

namespace MulTableApp
{
    class Program
    {
        static void Main()
        {
            string[][] firstRow = new string[2][];
            {
                firstRow[0] = new string[10]
                {
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

                firstRow[1] = new string[10]
                {
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
            };

            BuildTable(firstRow);
        }

        public static void BuildTable(string[][] arr1)
        {
            // левый верхний
            Console.Write($"{(char)9556}");

            // выводим верхнюю горизонталь таблицы
            for (int j = 1; j < arr1.Length+26; j++)
            {
                if (j != 13)
                {
                    Console.Write($"{(char)9552}");
                }
                else
                {
                    Console.Write($"{(char)9572}");
                }
            }

            // выводим правый верхний угол таблицы
            Console.WriteLine($"{(char) 9559}");

            // данные помещенные в таблицу
            for (int i = 0; i < arr1.Length; i++)
            {
                for (int j = 0; j < arr1[i].Length; j++)
                {
                    Console.Write($"{(char)9553}");
                    Console.Write($"{arr1[i][j]}");
                    Console.WriteLine();
                }

                // разделитель между столбиками
                //
            }

            //выводим правую вертикаль
            Console.WriteLine($"{(char)9553}");

            // выводим левый нижний угол таблицы
            Console.Write($"{(char)9562}");

            // выводим нижнюю горизонталь таблицы
            for (int j = 0; j < arr1.Length+25; j++)
            {
                if (j != 12)
                {
                    Console.Write($"{(char)9552}");
                }
                else
                {
                    Console.Write($"{(char)9575}");
                }
            }
            Console.Write($"{(char)9565}");
        }
    }
}