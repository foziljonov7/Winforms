using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Desktop.Dtos
{
    public class CreateBookDto
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public string Author { get; set; }
        public DateTime TimeOfWriting { get; set; }
    }
}
