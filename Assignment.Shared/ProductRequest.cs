using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Shared
{
    public class ProductRequest
    {
        public int Id { get; set; }
        public string NameProduct { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
    }
}
