using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Durgerking.Cafe.Dtos.FoodDtos
{
    public class CreateFoodDto
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public string Category { get; set; }
    }
}
