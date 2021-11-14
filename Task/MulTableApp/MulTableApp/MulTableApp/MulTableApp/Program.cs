using System;

namespace MulTableApp
{
    class Program
    {
        static void Main()
        {
            var generator = new MultiplicationTableGenerator();
            var manager = new TableManager();
            do
            {
                var mulTab = generator.Create(2, 5);
                var tabParams = manager.Analyzation(mulTab);
                var builder = new TableBuilder(tabParams, mulTab);
                builder.Build(tabParams, mulTab);

                Console.WriteLine("Q");
            } while (!(Console.ReadKey().Key == ConsoleKey.Q));
        }
    }
}