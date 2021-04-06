using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment.BackEnd.Models
{
    public class Product
    {
        public string ProductId { get; set; }
        public string NameProduct { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string ProductImg { get; set; }
        public int Rated { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; }
        public string CategoryID { get; set; }
        public Category Category { get; set; }
    }
}
