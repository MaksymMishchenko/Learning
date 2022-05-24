using System;
using System.IO;

namespace FileApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"G:\SomeFile.txt";

            var file = new FileInfo(path);
            FileStream stream = file.Create();

            var writer = new StreamWriter(stream);
            writer.Write("It's necessary to do it!");
            writer.Close();
            stream.Close();

            Console.WriteLine("File have been created!");

            Console.WriteLine("Press Enter to read data from file.");
            Console.ReadKey();

            var reader = new StreamReader(path);
            var text = reader.ReadToEnd();
            Console.WriteLine($"Text in file: {text}");
            reader.Close();
        }
    }
}
