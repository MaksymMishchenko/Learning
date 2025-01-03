namespace BooksApp.Models
{
    internal class Country
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? CapitalId { get; set; }
        public Capital Capital { get; set; }
    }
}
