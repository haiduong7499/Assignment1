using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment.BackEnd.Models
{
    public class Category
    {
        public string CategoryId { get; set; }

        [Required]
        [MaxLength(30)]
        public string Name { get; set; }
        public string Description { get; set; }
        public ICollection<Product> Product { get; set; }

    }
}
