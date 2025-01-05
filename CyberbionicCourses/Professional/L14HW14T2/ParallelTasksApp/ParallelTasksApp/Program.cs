using System;
using System.Threading;
using System.Threading.Tasks;

namespace ParallelTasksApp
{
    class Program
    {
        public static void WriteStars()
        {
            for (int i = 0; i < 20; i++)
            {
                Thread.Sleep(200);
                Console.Write("* ");
            }
        }
        public static void WriteZero()
        {
            for (int i = 0; i < 20; i++)
            {
                Thread.Sleep(200);
                Console.Write("# ");
            }
        }

        static void Main(string[] args)
        {
            TaskFactory factory = new TaskFactory();
            factory.StartNew(() => Parallel.Invoke(WriteStars, WriteZero));

            for (int i = 0; i < 20; i++)
            {
                Thread.Sleep(200);
                Console.WriteLine("-");
            }

            Console.ReadKey();
        }
    }
}
