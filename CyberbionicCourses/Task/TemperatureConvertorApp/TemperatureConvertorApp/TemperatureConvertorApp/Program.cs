using System;

namespace TemperatureConvertorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Добро пожаловать в конвертер температур c Цельсия(°C) в Фаренгейт (°F). \nВведите градусы по Цельсию: ");

            int userData = int.Parse(Console.ReadLine());

            TemperatureConvertor temperature = new TemperatureConvertor();
            var result = temperature.CelsiusToFahrenheit(userData);

            Console.WriteLine($"Результат: {userData}°C эквивалентно {result}°F");

            Console.ReadKey();
        }
    }
}
