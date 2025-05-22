using SAEcommerceApp.Models;
using System.Collections.Generic;

namespace SAEcommerceApp.Data
{
    public static class FakeProductData
    {
        public static List<Product> GetProducts()
        {
            var products = new List<Product>();

            for (int i = 1; i <= 50; i++)
            {
                products.Add(new Product
                {
                    Id = i,
                    Name = $"Product {i}",
                    Description = $"Description for product {i}",
                    Price = 100 + i * 10,
                    ImageUrl = $"https://via.placeholder.com/150?text=Product+{i}",
                    Rating = 3.5 + (i % 5) * 0.3,
                    Features = "Feature A, Feature B, Feature C"
                });
            }

            return products;
        }
    }
}
