using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment.BackEnd.Models
{
    public class Product
    {
<<<<<<< HEAD
        public string ProductId { get; set; }
=======
        public int Id { get; set; }
>>>>>>> a7c890a9e6622adff040cb2b29ff8a33389a8aa1
        public string NameProduct { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string ProductImg { get; set; }
        public int Rated { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; }
<<<<<<< HEAD
        public string CategoryID { get; set; }
=======
        public int BrandId { get; set; }
        public Brand Brand { get; set; }
        public int CategoryID { get; set; }
>>>>>>> a7c890a9e6622adff040cb2b29ff8a33389a8aa1
        public Category Category { get; set; }
    }
}
