namespace ProductsCartWeb.Models
{
    public class Product
    {
        public int? Id { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public string? Url { get; set; }
        public double? price { get; set; }

        public Product (string name)
        {
            Name = name;    
        }
    }
}
