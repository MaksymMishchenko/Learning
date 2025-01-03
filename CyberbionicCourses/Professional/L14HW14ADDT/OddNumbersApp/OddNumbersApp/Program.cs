using System;
using System.Linq;
using System.Threading;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace OddNumbersApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[1000000];

            Random random = new Random();
            Parallel.For(0, arr.Length, i => arr[i] = random.Next(-100, 100));

            Thread.Sleep(1000);

            ParallelQuery<int> oddNumbers = from item in arr.AsParallel()
                                            where item % 2 != 0
                                            orderby item
                                            select item;
            Thread.Sleep(1000);

            Parallel.ForEach(oddNumbers, items =>
            {
                Console.Write($"{items} ");
                Thread.Sleep(20);

            });
        
            Console.ReadKey();
        }
    }
}
