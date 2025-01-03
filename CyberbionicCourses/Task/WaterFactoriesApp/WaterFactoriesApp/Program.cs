using System;

namespace WaterFactoriesApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(">>> Welcome to Coca Cola company: <<<");
            Console.WriteLine(new string('-', 50));
            var clientCocaCola = new Client(new CocaColaFactory());
            var mixCocaColaWater = new CocaColaWater();
            Console.WriteLine("Mixed ingredients: ");
            clientCocaCola.Run();
            Console.WriteLine("\n\nThe product Coca Cola is ready to use!");
            
            Console.Write("\n");

            Console.WriteLine(">>> Welcome to Pepsi Cola company: <<<");
            Console.WriteLine(new string('-', 50));
            var clientPepsiCola = new Client(new PepsiColaFactory());
            Console.WriteLine("Mixed ingredients: ");
            clientPepsiCola.Run();
            Console.WriteLine("\nThe product Pepsi Cola is ready to use!");
        }
    }
}
