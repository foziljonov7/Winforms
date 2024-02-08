using Durgerking.Cafe.Dtos.SalesDtos;
using Durgerking.Cafe.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Durgerking.Cafe.Services
{
    public interface IProductSales
    {
        Task<List<Product>> GetProductSoldAsync();
        Task<Product> CreateProductSoldAsync(Guid id, CreateProductSoldDto SoldProduct);
        Task<(double price, int quantity)> SalesProductAsync(Guid id, int quantity);
    }
}
