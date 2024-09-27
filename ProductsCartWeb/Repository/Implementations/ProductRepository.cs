using Data.Models;
using Data.Repository;
using ProductsCartWeb.Repository.Interfaces;

namespace ProductsCartWeb.Repository.Implementations
{
    public class ProductRepository : BaseRepository<Product>, IProductRepository
    {
        public ProductRepository()
        {
            SeedProducts();
        }

        public static List<Product> Products;

        public static void SeedProducts()
        {
            Products = new List<Product>();
            Products.Add(new Product()
            {
                Id = new Guid().ToString(),
                Name = "Intel Core I5-9400F",
                Description = "Новый процессор Intel Core i5-9400F 9-го поколения, с кодовым названием микроархитектуры Coffee Lake. Предназначен для настольной платформы Intel LGA 1151. Принадлежит к семейству высокопроизводительных процессоров Core i5.",
                Price = 4500,
                Url = "https://hard.rozetka.com.ua/ua/intel_core_i5_9400f_bx80684i59400f/p72573399/"
            });
            Products.Add(new Product()
            {
                Id = new Guid().ToString(),
                Name = "AMD Ryzen 5 3600",
                Description = "Процесор AMD Ryzen 5 3600 з архітектурою Zen 2. Призначений для сокету AM4 та забезпечує високу продуктивність для настільних комп'ютерів.",
                Price = 4800,
                Url = ""
            });

            Products.Add(new Product()
            {
                Id = new Guid().ToString(),
                Name = "Intel Core i7-9700K",
                Description = "Процесор Intel Core i7-9700K 9-го покоління, 8 ядер і 8 потоків для максимального рівня продуктивності.",
                Price = 9000,
                Url = ""
            });

            Products.Add(new Product()
            {
                Id = new Guid().ToString(),
                Name = "AMD Ryzen 7 3700X",
                Description = "AMD Ryzen 7 3700X - високопродуктивний 8-ядерний процесор для ігрових та професійних систем.",
                Price = 9500,
                Url = ""
            });

            Products.Add(new Product()
            {
                Id = new Guid().ToString(),
                Name = "Intel Core i9-9900K",
                Description = "Флагманський процесор Intel Core i9-9900K з 8 ядрами і 16 потоками, розроблений для максимальної продуктивності.",
                Price = 14000,
                Url = ""
            });

            Products.Add(new Product()
            {
                Id = new Guid().ToString(),
                Name = "AMD Ryzen 9 3900X",
                Description = "12-ядерний процесор AMD Ryzen 9 3900X для робочих станцій і геймерських ПК, архітектура Zen 2.",
                Price = 12000,
                Url = ""
            });

            Products.Add(new Product()
            {
                Id = new Guid().ToString(),
                Name = "Intel Core i5-10600K",
                Description = "Процесор Intel Core i5-10600K для сокету LGA 1200, 6 ядер і 12 потоків, оптимальний для ігор і роботи.",
                Price = 5600,
                Url = ""
            });

            Products.Add(new Product()
            {
                Id = new Guid().ToString(),
                Name = "AMD Ryzen 5 5600X",
                Description = "Шестиядерний процесор AMD Ryzen 5 5600X з архітектурою Zen 3, чудово підходить для ігор.",
                Price = 7000,
                Url = ""
            });

            Products.Add(new Product()
            {
                Id = new Guid().ToString(),
                Name = "Intel Core i7-10700F",
                Description = "Процесор Intel Core i7-10700F з 8 ядрами та 16 потоками, без вбудованого графічного ядра.",
                Price = 8600,
                Url = ""
            });

            Products.Add(new Product()
            {
                Id = new Guid().ToString(),
                Name = "AMD Ryzen 7 5800X",
                Description = "8-ядерний процесор AMD Ryzen 7 5800X з архітектурою Zen 3 для геймерів і творців контенту.",
                Price = 11500,
                Url = ""
            });

            Products.Add(new Product()
            {
                Id = new Guid().ToString(),
                Name = "Intel Core i9-11900K",
                Description = "Флагманський процесор Intel Core i9-11900K з 8 ядрами та 16 потоками, підтримка PCIe 4.0.",
                Price = 15500,
                Url = ""
            });

        }

        public override Task<Product> GetAsync(string id)
        {
            return Task.FromResult(Products.FirstOrDefault(x => x.Id == id));
        }

        public override Task<List<Product>> GetRangeAsync(List<string> ids)
        {
            return Task.FromResult(Products.FindAll(x => ids.Contains(x.Id)));
        }

        public override Task<List<Product>> GetAllAsync()
        {
            return Task.FromResult(Products);
        }
    }
}
