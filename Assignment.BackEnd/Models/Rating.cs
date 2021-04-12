using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment.BackEnd.Models
{
    public class Rating
    {
        public int ID { get; set; }
        public string Comments { get; set; }
        public DateTime PublishDate { get; set; }
        public int Articles { get; set; }
        public Product Article { get; set; }
        public int Rate { get; set; }
    }
}
