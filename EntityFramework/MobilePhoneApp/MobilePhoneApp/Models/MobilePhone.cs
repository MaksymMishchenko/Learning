namespace MobilePhoneApp.Models
{
    class MobilePhone
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Cost { get; set; }
        public int? ManufacturerId { get; set; }
        public Manufacturer Manufacturer { get; set; }
    }
}
