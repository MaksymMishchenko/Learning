using System;

namespace CarApp
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("\t ===Car1===");
            var car1 = new Car();
            car1.DriveForward();
            car1.PrintSpeed();
            car1.Stop();
            car1.PrintSpeed();

            Console.WriteLine(new string ('-', 50));

            Console.WriteLine("\t ===Car2===");

            var car2 = new Car();
            car1.DriveBackward();
            car1.PrintSpeed();
            car1.Stop();
            car1.PrintSpeed();
        }
    }
}
