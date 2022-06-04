using System;
using System.IO;
using System.Xml.Serialization;

namespace DeSerializationCarApp
{
    class Program
    {
        static void Main(string[] args)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Car));

            FileStream original = new FileStream("document.xml", FileMode.Open, FileAccess.Read);

            var auto = (Car)serializer.Deserialize(original);
            Console.WriteLine($"Car: {auto.CarBrand}, Model: {auto.Model}, Price: {auto.Price}, MaxSpeed: {auto.MaxSpeed}");

            Console.WriteLine("Deserialization was seccussful");

            original.Close();
        }
    }
}
