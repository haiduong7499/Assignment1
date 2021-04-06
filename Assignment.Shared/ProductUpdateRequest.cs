using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Shared
{
    public class ProductUpdateRequest
    {
        public string NameProduct { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string ProductImg { get; set; }
        public int Rated { get; set; }
        public DateTime UpdateDate { get; set; }
        public string CategoryID { get; set; }
    }
}
