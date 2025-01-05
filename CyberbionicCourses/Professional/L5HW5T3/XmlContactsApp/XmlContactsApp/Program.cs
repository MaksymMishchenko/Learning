using System;
using System.Xml;

namespace XmlContactsApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var xmlReader = new XmlTextReader("MyDocument.xml");

            while (xmlReader.Read())
            {
                if (xmlReader.NodeType == XmlNodeType.Element)
                {
                    if (xmlReader.Name.Equals("Contact"))
                    {
                        Console.WriteLine($"Telephone numbers: {xmlReader.GetAttribute("TelephoneNumber")}");
                    }
                }
            }

            Console.ReadKey();
        }
    }
}
