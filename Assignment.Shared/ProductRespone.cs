using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Assignment.Shared
{
    public class ProductRespone
    {
        public string ProductId { get; set; }
        public string NameProduct { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string ProductImg { get; set; }
        public int Rated { get; set; }
        public int CategoryID { get; set; }
    }
}
