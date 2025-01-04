using System;
using System.IO;
using System.Xml.Serialization;

namespace CarApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // var mercedes = new Car("Mercedes", "ML 500", 50.000M, "300");
            var mercedes = new Car();
            mercedes.CarBrand = "Mercedes";
            mercedes.Model = "ML 500";
            mercedes.Price = 50.000M;
            mercedes.MaxSpeed = "300";
            
            FileStream stream = new FileStream("document.xml", FileMode.Create, FileAccess.Write);
            XmlSerializer serializer = new XmlSerializer(typeof(Car));
            serializer.Serialize(stream, mercedes);
            stream.Close();
            Console.WriteLine("Serialize was successful!");
            Console.ReadKey();
        }
    }
}
