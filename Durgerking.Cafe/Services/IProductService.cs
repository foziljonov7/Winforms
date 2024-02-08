using Durgerking.Cafe.Dtos.ProductDtos;
using Durgerking.Cafe.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Durgerking.Cafe.Services
{
    public interface IProductService
    {
        Task<List<Product>> GetProductsAsync();
        Task<List<Product>> GetProductCategoriesAsync(string category);
        Task<Product> CreateProductAsync(CreateProductDto newProduct);
        Task<Product> UpdateProductAsync(Guid id, UpdateProductDto product);
        Task<bool> DeleteProductAsync(Guid id);
    }
}
