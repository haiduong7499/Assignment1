using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Shared
{
    public class ProductRequest
    {
        public string NameProduct { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public IFormFile ProductImg { get; set; }
        public int Rate { get; set; }
        public string CategoryID { get; set; }
    }
}
