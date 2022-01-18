using System;

namespace WaterFactoriesApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var clientCocaCola = new Client(new CocaColaFactory());
            var clientPepsiCola = new Client(new PepsiColaFactory());
        }
    }
}
