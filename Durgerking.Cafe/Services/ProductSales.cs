using Durgerking.Cafe.Dtos.SalesDtos;
using Durgerking.Cafe.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Durgerking.Cafe.Services
{
    public class ProductSales : IProductSales
    {
        private List<Product> soldProducts = new List<Product>();
        public Task<Product> CreateProductSoldAsync(Guid id, CreateProductSoldDto SoldProduct)
        {
            throw new NotImplementedException();
        }

        public Task<List<Product>> GetProductSoldAsync()
        {
            throw new NotImplementedException();
        }

        public Task<(double price, int quantity)> SalesProductAsync(Guid id, int quantity)
        {
            throw new NotImplementedException();
        }
    }
}
