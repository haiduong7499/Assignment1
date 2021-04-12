using Assignment.BackEnd.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment.BackEnd.ViewModels
{
    public class RatingVM
    {
        public string Title { get; set; }   
        public List<Rating> ListComment { get; set; }
        public string Comment { get; set; }
        public string ProductId { get; set; }
        public int Rating { get; set; }
    }
}
