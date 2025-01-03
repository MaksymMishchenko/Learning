namespace BooksApp.Models
{
    internal class Book
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Author Author { get; set; }
        public int? PublishHouseId { get; set; }
        public PublishHouse PublishHouse { get; set; }
    }
}
