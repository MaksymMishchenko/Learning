using System;

namespace WaterFactoriesApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Coca Cola company: ");
            var clientCocaCola = new Client(new CocaColaFactory());
            clientCocaCola.Run();

            Console.WriteLine(new string('-', 50));

            Console.WriteLine("Welcome to Pepsi Cola company: ");
            var clientPepsiCola = new Client(new PepsiColaFactory());
            clientPepsiCola.Run();
        }
    }
}
