using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace StudentsApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var artur = new Student(Guid.NewGuid(), "Artur", 23, "P-312");
            artur.ShowInfo();

            // serialization
            using (var memoryStream = new MemoryStream())
            {
                new BinaryFormatter().Serialize(memoryStream, artur);
                var bytes = memoryStream.ToArray();
            }

            Console.ReadKey();
        }
    }
}
