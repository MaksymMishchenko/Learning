using System.Text;
using System.Xml;

namespace XMLCreatorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var xmlTextWriter = new XmlTextWriter("TelephoneBook", Encoding.UTF8);

            xmlTextWriter.Formatting = Formatting.Indented;
            xmlTextWriter.IndentChar = '\t';
            xmlTextWriter.Indentation = 1;

            xmlTextWriter.WriteStartDocument();
            xmlTextWriter.WriteStartElement("MyContacts");
            xmlTextWriter.WriteStartElement("Contact");
            xmlTextWriter.WriteStartAttribute("TelephoneNumber");
            xmlTextWriter.WriteString("+380674153598");
            xmlTextWriter.WriteEndAttribute();
            xmlTextWriter.WriteString("Maksym Mischenko");
            xmlTextWriter.WriteEndElement();
            xmlTextWriter.WriteEndElement();

            xmlTextWriter.Close();
        }
    }
}
