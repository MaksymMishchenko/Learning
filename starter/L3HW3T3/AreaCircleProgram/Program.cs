using System;

namespace AreaCircleProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            const double pi = 3.141; //число Pi
            var r = pi * Math.Pow(pi, 2); //создаем переменную r, помещаем в нее результат формулы
            Console.Write("Площадь нашего круга: ");
            Console.WriteLine(r); //выводим переменную на экран
            Console.ReadKey(); //Задержка

        }
    }
}
