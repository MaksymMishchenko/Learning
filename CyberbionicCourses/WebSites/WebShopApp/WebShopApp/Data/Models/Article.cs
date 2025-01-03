namespace WebShopApp.Data.Models
{
    public class Article
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Content { get; set; }
        public string Image { get; set; }
        public ArticleCategory Category { get; set; }
    }
}
