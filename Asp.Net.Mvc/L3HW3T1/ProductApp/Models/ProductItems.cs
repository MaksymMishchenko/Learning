namespace ProductApp.Models
{
    public class ProductItems
    {
        public List<Product> GetAllProducts()
        {
            List<Product> products = new List<Product>();

            products.Add(new Product(1, "Product item 1", 1, DateTime.Parse("01-01-2022")));
            products.Add(new Product(2, "Product item 2", 3, DateTime.Parse("02-02-2022")));
            products.Add(new Product(3, "Product item 3", 2, DateTime.Parse("03-05-2022")));
            products.Add(new Product(4, "Product item 4", 5, DateTime.Parse("04-08-2022")));
            products.Add(new Product(5, "Product item 5", 4, DateTime.Parse("08-06-2022")));
            products.Add(new Product(6, "Product item 6", 8, DateTime.Parse("05-03-2022")));
           
            return products;
        }
    }
}
