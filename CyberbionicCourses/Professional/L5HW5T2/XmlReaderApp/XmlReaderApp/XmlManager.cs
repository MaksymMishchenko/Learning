using System;
using System.IO;
using System.Text;
using System.Xml;

namespace XmlReaderApp
{
    public class XmlManager
    {
        private XmlTextWriter _xmlWriter;
        private FileStream _stream;
        private XmlTextReader _xmlReader;
        private string _path;

        public XmlManager(string path)
        {
            _path = path;
            _xmlWriter = new XmlTextWriter(_path, Encoding.UTF8);
        }

        public void BuildXmlDocument()
        {
            _xmlWriter.Formatting = Formatting.Indented;
            _xmlWriter.IndentChar = '\t';
            _xmlWriter.Indentation = 1;

            _xmlWriter.WriteStartDocument();

            _xmlWriter.WriteStartElement("MyContacts");
            _xmlWriter.WriteStartElement("Contact");
            _xmlWriter.WriteStartAttribute("TelephoneNumber");
            _xmlWriter.WriteString("+380674153598");
            _xmlWriter.WriteEndAttribute();
            _xmlWriter.WriteString("Maksym Mischenko");
            _xmlWriter.WriteEndElement();

            _xmlWriter.WriteStartElement("Contact");
            _xmlWriter.WriteStartAttribute("TelephoneNumber");
            _xmlWriter.WriteString("+380672222222");
            _xmlWriter.WriteEndAttribute();
            _xmlWriter.WriteString("Peter Svarovski");
            _xmlWriter.WriteEndElement();

            _xmlWriter.WriteStartElement("Contact");
            _xmlWriter.WriteStartAttribute("TelephoneNumber");
            _xmlWriter.WriteString("+380671111111");
            _xmlWriter.WriteEndAttribute();
            _xmlWriter.WriteString("Artur Tatarchuk");
            _xmlWriter.WriteEndElement();

            _xmlWriter.WriteEndElement();

            _xmlWriter.Close();
        }

        public void ReadXmlDocument()
        {
            _stream = new FileStream(_path, FileMode.Open);
            _xmlReader = new XmlTextReader(_stream);

            while (_xmlReader.Read())
            {
                Console.WriteLine("Type: {0, -15} Name: {1, -15} Value: {2, -15} Attributes: {3, -15}", _xmlReader.NodeType,
                    _xmlReader.Name, _xmlReader.Value, _xmlReader.GetAttribute("TelephoneNumber"));
            }

            _stream.Close();
            _xmlReader.Close();
        }
    }
}
