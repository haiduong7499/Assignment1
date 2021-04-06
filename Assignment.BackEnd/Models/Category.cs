using System;
using System.Collections.Generic;
<<<<<<< HEAD
=======
using System.ComponentModel;
>>>>>>> a7c890a9e6622adff040cb2b29ff8a33389a8aa1
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment.BackEnd.Models
{
    public class Category
    {
<<<<<<< HEAD
        public string CategoryId { get; set; }
=======
        public int ID { get; set; }
        public int CategoryId { get; set; }
>>>>>>> a7c890a9e6622adff040cb2b29ff8a33389a8aa1

        [Required]
        [MaxLength(30)]
        public string Name { get; set; }
<<<<<<< HEAD
        public string Description { get; set; }
        public ICollection<Product> Product { get; set; }

=======
>>>>>>> a7c890a9e6622adff040cb2b29ff8a33389a8aa1
    }
}
