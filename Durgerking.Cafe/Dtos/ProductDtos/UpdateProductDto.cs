using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Durgerking.Cafe.Dtos.ProductDtos
{
    public class UpdateProductDto
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
        public string Category { get; set; }
        public double Valomu { get; set; }
    }
}
