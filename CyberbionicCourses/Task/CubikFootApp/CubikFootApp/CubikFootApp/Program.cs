using System;

namespace CubikFootApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //10 минут

            Console.WriteLine("Введите ваше значение в галлонах: ");
            double gallon = double.Parse(Console.ReadLine());
            double result = ConvertGallonToCubikFoot(gallon);

            Console.WriteLine($"{gallon} галлонов равно: {result} кубическим футам.");
            Console.ReadKey();
        }

        //Метод, который конвертирует галлоны в кубические футы
        //15 минут
        public static double ConvertGallonToCubikFoot(double gallon)
        {
            const double oneCubikFoot = 7.481;
            double result = gallon / oneCubikFoot;
            return result;
        }
    }
}