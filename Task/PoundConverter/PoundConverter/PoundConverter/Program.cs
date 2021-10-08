using System;
using PoundConverter.Model;

namespace PoundConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            //принимаем фунты
            Console.WriteLine("Введите фунты:");
            decimal pounds = decimal.Parse(Console.ReadLine());

            //принимаем шиллинги
            Console.WriteLine("Введите шиллинги:");
            decimal shillings = decimal.Parse(Console.ReadLine());

            //принимаем пенсы
            Console.WriteLine("Введите пенсы:");
            decimal pennies = decimal.Parse(Console.ReadLine());


            Converter converter = new Converter();
            var a = converter.NewPound(pounds, shillings, pennies);

            ShowResult show = new ShowResult();
            show.Show($"{a.Pound}.{Math.Round(a.Pennies)}");
        }
    }
}