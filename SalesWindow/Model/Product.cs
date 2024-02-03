using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesWindow.Model
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
        public double Volume { get; set; }
        public string Made { get; set; }
        public string Category { get; set; }
        public DateTime CameDate { get; set; }
    }
}
