using System;
using System.IO;

namespace FoldersApp
{
    class Program
    {
        static void Main(string[] args)
        {

            for (int i = 0; i < 100; i++)
            {
                string path = @"G:\Folder_" + i;
                var directory = new DirectoryInfo(path);
                directory.Create();
            }

            Console.WriteLine("Folders have been created!");
            Console.WriteLine("Click Enter to deletes created folders");

            Console.ReadKey();

            for (int i = 0; i < 100; i++)
            {
                string path = @"G:\Folder_" + i;
                var directory = new DirectoryInfo(path);
                
                if (directory.Exists)
                {
                    Directory.Delete(path);
                }
            }

            Console.WriteLine("Folders have been deleted!");
        }
    }
}
