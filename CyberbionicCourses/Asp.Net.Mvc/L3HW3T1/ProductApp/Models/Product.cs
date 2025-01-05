namespace ProductApp.Models
{
    public record class Product(int Id, string? Name, decimal Price, DateTime CreatedDate);
}
