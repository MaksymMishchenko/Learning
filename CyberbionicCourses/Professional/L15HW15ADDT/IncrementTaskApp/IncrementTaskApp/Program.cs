using System;

namespace IncrementTaskApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Press any key no increment...");
            Console.ReadKey();

            for (int i = 0; i < 3; i++)
            {
                new Count().DoIncrementAsync();
            }

            Console.ReadKey();
        }
    }
}
