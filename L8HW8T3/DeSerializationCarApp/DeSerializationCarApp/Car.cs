using System.Xml.Serialization;

namespace DeSerializationCarApp
{
    [XmlRoot("Type")]
    public class Car
    {
        [XmlAttribute("Brand")]
        public string CarBrand { get; set; }

        [XmlAttribute]
        public string Model { get; set; }

        [XmlAttribute]
        public decimal Price { get; set; }

        [XmlAttribute("Speed")]
        public string MaxSpeed { get; set; }
    }
}
