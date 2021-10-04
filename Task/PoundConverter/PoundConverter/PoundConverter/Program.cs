using System;

namespace PoundConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            //принимаем фунты
           Console.WriteLine("Введите фунты:");
           int pounds = int.Parse(Console.ReadLine());

           //принимаем шиллинги
            Console.WriteLine("Введите шиллинги:");
            int shillings = int.Parse(Console.ReadLine());
            
            //принимаем пенсы
            Console.WriteLine("Введите пенсы:");
            int pennies = int.Parse(Console.ReadLine());

            var result = new PoundConverter();
            Console.WriteLine(result.ConvertToPound( pounds, shillings, pennies));
        }
    }
}
