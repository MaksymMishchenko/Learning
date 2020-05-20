using System;

namespace AreaCircleProgram
{
    class Program
    {
        static void Main()
        {
            const double pi = 3.141; //число Pi
            int r = 5;
            var result = pi * Math.Pow(r, 2); //создаем переменную r, помещаем в нее результат формулы
            Console.Write("Площадь нашего круга: ");
            Console.WriteLine(result); //выводим переменную на экран
            Console.ReadKey(); //Задержка

        }
    }
}
