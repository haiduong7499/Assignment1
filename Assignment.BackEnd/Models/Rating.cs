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
        public string ProductId { get; set; }
        public virtual Product Product { get; set; }
        public int Rate { get; set; }
    }
}
