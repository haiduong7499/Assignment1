using Microsoft.AspNetCore.Http;
using System;

namespace Assignment.Shared
{
    public class ProductUpdateRequest
    {
        public string NameProduct { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public IFormFile ProductImg { get; set; }
        public int Rated { get; set; }
        public DateTime UpdateDate { get; set; }
        public string CategoryID { get; set; }
    }
}
