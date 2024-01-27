using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Desktop.Models
{
    public class Book
    {
        public int  Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string Author { get; set; }
        public DateTime TimeOfWriting { get; set; }
        public DateTime Created { get; set; }
    }
}
