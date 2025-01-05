using System;

namespace CurrencyConverterApp
{
    class Program
    {
        static void Main()
        {
            Console.Write("Добро пожаловать. \nВведите сумму в долларах: ");

            float userValue = float.Parse(Console.ReadLine());
            CurrencyConvertor instance = new CurrencyConvertor();

            Console.WriteLine("\nНа биржевых торгах:\n");

            float convertToPound = instance.ConvertDollarToPound(userValue);
            Console.WriteLine($"За {userValue} долларов можно купить {convertToPound} английских фунтов");

            float convertToFranc = instance.ConvertDollarToFranc(userValue);
            Console.WriteLine($"За {userValue} долларов можно купить {convertToFranc} французских франков");

            float convertToMark = instance.ConvertDollarToMark(userValue);
            Console.WriteLine($"За {userValue} долларов можно купить {convertToMark} немецких марок");

            float convertToYen = instance.ConvertDollarToYen(userValue);
            Console.WriteLine($"За {userValue} долларов можно купить {convertToYen} японских йен");

            Console.ReadKey();
        }
    }
}
