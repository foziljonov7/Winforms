using Durgerking.Cafe.Dtos.FoodDtos;
using Durgerking.Cafe.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Durgerking.Cafe.Services
{
    public class FoodService : IFoodService
    {
        private static List<Food> foods = new List<Food>();
        private static List<Food> soldFoods = new List<Food>();
        public async Task<Food> CreateFoodAsync(CreateFoodDto newFood)
        {
            var food = new Food
            {
                Id = Guid.NewGuid(),
                Name = newFood.Name,
                Price = newFood.Price,
                Category = newFood.Category
            };

            foods.Add(food);
            return await Task.FromResult(food);
        }

        public async Task<bool> DeleteFoodAsync(Guid id)
        {
            var food = await GetFoodAsync(id);
            foods.Remove(food);
            return true;
        }

        public async Task<Food> GetFoodAsync(Guid id)
        {
            var food = foods.Find(f => f.Id == id);

            if (food is null)
                return null;

            return await Task.FromResult(food);
        }

        public async Task<List<Food>> GetFoodCategoriesAsync(string category)
        {
            var foodCategories = foods.FindAll(f => f.Category == category);

            if (foodCategories is null)
                return null;

            return foodCategories;
        }

        public async Task<List<Food>> GetFoodsAsync()
            => await Task.FromResult(foods);

        public async Task<List<Food>> GetFoodSoldAsync()
            => await Task.FromResult(soldFoods);

        public async Task<(double price, int quantity)> SalesFoodAsync(Guid id, int quantity)
        {
            var food = await GetFoodAsync(id);

            if (food is null || food.Quantity < quantity)
                return (price: 0, quantity: 0);

            var totalPrice = food.Price * quantity;
            food.Quantity -= quantity;

            var soldFoodIndex = soldFoods.FindIndex(f => f.Id == id);

            if (soldFoodIndex != -1)
            {
                soldFoods[soldFoodIndex].Quantity += quantity;
                soldFoods[soldFoodIndex].Price += totalPrice;
            }
            else
            {
                var newSoldFood = new Food
                {
                    Id = food.Id,
                    Name = food.Name,
                    Price = totalPrice,
                    Quantity = quantity,
                    Category = food.Category,
                    OrderTime = DateTime.UtcNow
                };

                soldFoods.Add(newSoldFood);
            }

            return (price: totalPrice, quantity: quantity);
        }

        public async Task<Food> UpdateFoodAsync(Guid id, UpdateProductDto food)
        {
            var updateFood = await GetFoodAsync(id);

            updateFood.Name = food.Name;
            updateFood.Price = food.Price;
            updateFood.Category = food.Category;

            var index = foods.FindIndex(f => f.Id == id);
            if (index != -1)
            {
                foods[index] = updateFood;
            }
            else
            {
                return null;
            }

            return updateFood;
        }
    }
}
