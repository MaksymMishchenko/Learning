namespace TemplateApp.Models
{
    public class ProductManager
    {
        public List<Product> GetAllProducts( int count = 5)
        { 
         List<Product> products = new List<Product>();

            for (int i = 0; i < 20; i++)
            {
                products.Add(new Product(i + 1, $"Product item + {i}", i + 1 * 2));
            }

            return products; 
        }
    }
}
