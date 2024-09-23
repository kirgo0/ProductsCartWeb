namespace Data.Models
{
    public class Product
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public string? Url { get; set; }
        public double? Price { get; set; }

        public Product() { }
    }
}
