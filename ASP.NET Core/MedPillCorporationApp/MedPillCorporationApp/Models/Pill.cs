namespace MedPillCorporationApp.Models
{
    public class Pill
    {
        public int PillId { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public string Instruction { get; set; }
        public string Manufacturer { get; set; }
        public string Country { get; set; }
        public int Total { get; set; }
    }
}
