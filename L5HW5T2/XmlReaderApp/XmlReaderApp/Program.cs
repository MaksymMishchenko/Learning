using System;

namespace XmlReaderApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var xmlManager = new XmlManager("MyDocument.xml");
            xmlManager.BuildXmlDocument();
            xmlManager.ReadXmlDocument();

            Console.ReadKey();
        }
    }
}
