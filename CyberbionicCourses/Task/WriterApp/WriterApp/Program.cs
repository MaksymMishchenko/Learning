using System;
using System.Diagnostics;
using System.IO;
using System.Threading.Tasks;

namespace WriterApp
{
    class Program
    {
        static void Writer()
        {
            using (var writer = new StreamWriter("textAsync.txt", true))
            {
                for (int i = 0; i < 100000; i++)
                {
                    writer.Write(i);
                }
            }
        }

        static async Task WriterAsync()
        {
            await Task.Run(() => Writer());
        }

        static void Main(string[] args)
        {
            var sw = new Stopwatch();
            sw.Start();

            WriterAsync();

            sw.Stop();

            Console.WriteLine($"Elapsed time for WriteAsync: {sw.Elapsed.TotalMilliseconds}");
            sw.Reset();

            sw.Start();
            using (var writer = new StreamWriter("text.txt", true))
            {
                for (int i = 0; i < 100000; i++)
                {
                    writer.Write(i);
                }
            }

            sw.Stop();
            Console.WriteLine($"Elapsed time for Write: {sw.Elapsed.TotalMilliseconds}");
        }
    }
}
