using Durgerking.Cafe.Dtos.ProductDtos;
using Durgerking.Cafe.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Durgerking.Cafe.Services
{
    public class ProductService : IProductService
    {
        private static List<Product> products = new List<Product>();
        public Task<Product> CreateProductAsync(CreateProductDto newProduct)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteProductAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Product>> GetProductCategoriesAsync(string category)
        {
            throw new NotImplementedException();
        }

        public Task<List<Product>> GetProductsAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Product> UpdateProductAsync(Guid id, UpdateProductDto product)
        {
            throw new NotImplementedException();
        }
    }
}
