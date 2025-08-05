using ProductManager.API.Models;

namespace ProductManager.Tests.Fixtures
{
    public static class ProductFixture
    {
        public static List<Product> GetTestUsers()
        {
            var products = new List<Product>();
            products.Add(new() { Id = 1, Name = "Product 1", Description = "Description 1", Price = 1 });
            products.Add(new() { Id = 2, Name = "Product 2", Description = "Description 2", Price = 2 });
            products.Add(new() { Id = 3, Name = "Product 3", Description = "Description 3", Price = 3 });
            products.Add(new() { Id = 4, Name = "Product 4", Description = "Description 4", Price = 4 });
            products.Add(new() { Id = 5, Name = "Product 5", Description = "Description 5", Price = 5 });
            return products;
        }
    }
}