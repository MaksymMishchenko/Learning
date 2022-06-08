using System;
using System.IO;
using System.Threading;

namespace FileAccessApp
{
    class Program
    {
        private static FileStream file1 = File.Open("file1.txt", FileMode.Open, FileAccess.Read);
        private static StreamReader reader1 = new(file1);

        private static FileStream file2 = File.Open("file2.txt", FileMode.Open, FileAccess.Read);
        private static StreamReader reader2 = new(file2);

        private static FileStream file3 = File.Open("file3.txt", FileMode.Create, FileAccess.Write);
        private static StreamWriter writer = new(file3);

        private static Random random = new();

        public static void ReadWriteFile()
        {
            using (new ThreadManager(new BlockObject(10)))
            {
                var wait = random.Next(10, 200);

                string text1 = reader1.ReadToEnd();
                Thread.Sleep(wait);

                string text2 = reader2.ReadToEnd();
                Thread.Sleep(wait);
                writer.Flush();

                writer.Write(text1);
                writer.WriteLine("\n");
                writer.Write(text2);
            }
        }

        static void Main(string[] args)
        {
            Thread[] threads = new Thread[2];
            for (int i = 0; i < threads.Length; i++)
                threads[i] = new Thread(ReadWriteFile);

            for (int i = 0; i < threads.Length; i++)
                threads[i].Start();
            Console.WriteLine("Data from file1 and file2 was copied successful!");
        }
    }
}
