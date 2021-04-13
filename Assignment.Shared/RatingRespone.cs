using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Shared
{
    public class RatingRespone
    {
        public string ProductID { get; set; }

        public string Comments { get; set; }
        public DateTime PublishDate { get; set; }
        public int Rate { get; set; }
    }
}
