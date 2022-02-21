namespace ClientsApp.Models
{
    public class Client
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public City CityId { get; set; }
    }
}
