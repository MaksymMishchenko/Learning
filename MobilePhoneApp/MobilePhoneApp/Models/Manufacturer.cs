namespace MobilePhoneApp.Models
{
    class Manufacturer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? HeadquartersId { get; set; }
        public Headquarters Headquarters { get; set; }
    }
}
