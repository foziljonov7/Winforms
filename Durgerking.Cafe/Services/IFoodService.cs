using Durgerking.Cafe.Dtos.FoodDtos;
using Durgerking.Cafe.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Durgerking.Cafe.Services
{
    public interface IFoodService
    {
        Task<List<Food>> GetFoodsAsync();
        Task<Food> GetFoodAsync(Guid id);
        Task<List<Food>> GetFoodCategoriesAsync(string category);
        Task<Food> CreateFoodAsync(CreateFoodDto newFood);
        Task<Food> UpdateFoodAsync(Guid id, UpdateProductDto food);
        Task<bool> DeleteFoodAsync(Guid id);
        Task<(double price, int quantity)> SalesFoodAsync(Guid id, int quantity);
        Task<List<Food>> GetFoodSoldAsync();
    }
}
