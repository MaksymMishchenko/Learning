using System;

namespace MemoryCleanerApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program is started");
            Console.WriteLine(new string('-', 18));
            using (var @object = new LargeObject())
            {
                for (int i = 0; i < 10000000; i++)
                {
                    @object.Add(new LargeObject());
                }
            }

            var largeObject = new LargeObject();
            largeObject.Dispose();
            largeObject.Dispose();
            largeObject.Dispose();

            Console.ReadKey();
        }
    }
}
