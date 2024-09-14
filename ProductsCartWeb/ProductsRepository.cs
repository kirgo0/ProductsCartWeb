using ProductsCartWeb.Models;

namespace ProductsCartWeb
{
    public class ProductsRepository
    {
        public static List<Product> Products;

        public static void SeedProducts()
        {
            Products = new List<Product>();
            Products.Add(new Product("Aboba1"));
            Products.Add(new Product("Aboba2"));
            Products.Add(new Product("Aboba3"));
            Products.Add(new Product("Aboba14"));
            Products.Add(new Product("Abobaasdf sdadf sdadf1"));
            Products.Add(new Product("Aboba1sd sd s sdsdsd"));
            Products.Add(new Product("Aboba1sdsdsd "));
            Products.Add(new Product("Aboba1222"));
            Products.Add(new Product("Aboba1444"));
        }
    }
}
