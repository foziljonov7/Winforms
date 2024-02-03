using SalesWindow.Dtos;
using SalesWindow.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesWindow.Services
{
    public interface IProductService
    {
        Task<List<Product>> GetProducts();
        Task<Product> GetProduct(int id);
        Task<Product> CreateProduct(CreateProductDto newProduct);
        Task<(double TotalPrice, int QuantitySold)> SalesProduct(int id, int quantity);
    }
}
