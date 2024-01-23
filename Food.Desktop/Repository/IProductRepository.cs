using Food.Desktop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Food.Desktop.Repository
{
    public interface IProductRepository
    {
        Task<List<Product>> GetProducts();
        Task<Product> GetProduct(int id);
        Task<Product> CreateProduct(Product newProduct);
        Task<Product> UpdateProduct(Product updateProduct);
        Task<bool> RemoveProduct(int id);
    }
}
