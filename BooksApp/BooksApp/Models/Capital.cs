namespace BooksApp.Models
{
    internal class Capital
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? PublishHouseId { get; set; }
        public PublishHouse PublishHouse { get; set; }
    }
}
