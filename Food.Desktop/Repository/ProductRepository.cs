using Food.Desktop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Food.Desktop.Repository
{
    public class ProductRepository : IProductRepository
    {
        private static List<Product> product = new List<Product>()
        {
            new Product
            {
                Id = 1,
                Name = "Kupen",
                Price = 8000,
                Made = "Uzb",
                CreateDate = DateTime.Now,
                EndDate = DateTime.Now
            }
        };
        public Task<Product> CreateProduct(Product newProduct)
        {
            var prd = new Product
            {
                Id = newProduct.Id,
                Name = newProduct.Name,
                Price = newProduct.Price,
                Made = newProduct.Made,
                CreateDate = newProduct.CreateDate,
                EndDate = newProduct.EndDate
            };

            product.Add(prd);
            return Task.FromResult(prd);
        }

        public Task<Product> GetProduct(int id)
        {
            var productId = product.Find(p => p.Id == id);
            if (productId is null)
                return null;

            return Task.FromResult(productId);
        }

        public async Task<List<Product>> GetProducts()
            => await Task.FromResult(product);

        public async Task<bool> RemoveProduct(int id)
        {
            var productId = await GetProduct(id);
            product.Remove(productId);
            return true;
        }

        public async Task<Product> UpdateProduct(Product updateProduct)
        {
            var productId = await GetProduct(updateProduct.Id);

            if(productId != null)
            {
                productId.Name = updateProduct.Name;
                productId.Price = updateProduct.Price;
                productId.Made = updateProduct.Made;
                productId.CreateDate = updateProduct.CreateDate;
                productId.EndDate = updateProduct.EndDate;
            }

            return productId;
        }
    }
}
