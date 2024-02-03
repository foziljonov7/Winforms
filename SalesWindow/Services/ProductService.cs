using SalesWindow.Dtos;
using SalesWindow.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesWindow.Services
{
    public class ProductService : IProductService
    {
        private static List<Product> products = new List<Product>()
        {
            new Product
            {
                Id = 1,
                Name = "Milliy cola",
                Price = 5000,
                Quantity = 100,
                Volume = 0.5,
                Made = "uzb",
                Category = "Gazli suv",
                CameDate = DateTime.UtcNow.AddHours(5)
            }
        };
        public Task<Product> CreateProduct(CreateProductDto newProduct)
        {
            var product = new Product
            {
                Id = new Random().Next(1, 100),
                Name = newProduct.Name,
                Price = newProduct.Price,
                Quantity = newProduct.Quantity,
                Made = newProduct.Made,
                Volume = newProduct.Volume,
                Category = newProduct.Category,
                CameDate = DateTime.UtcNow.AddHours(5)
            };

            products.Add(product);
            return Task.FromResult(product);
        }

        public async Task<Product> GetProduct(int id)
        {
            var product = products.Find(p => p.Id == id);

            if (product is null)
                return null;

            return product;
        }

        public async Task<List<Product>> GetProducts()
            => await Task.FromResult(products);

        public async Task<(double TotalPrice, int QuantitySold)> SalesProduct(int id, int quantity)
        {
            var product = await GetProduct(id);

            if (product is null || product.Quantity < quantity)
                return (TotalPrice: 0, QuantitySold: 0);

            double totalPrice = product.Price * quantity;

            product.Quantity -= quantity;

            return (totalPrice: totalPrice, QuantitySold: quantity);
        }
    }
}
