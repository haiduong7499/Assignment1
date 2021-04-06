﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment.BackEnd.Models
{
    public class Category
    {
        public int ID { get; set; }
        public int CategoryId { get; set; }

        [Required]
        [MaxLength(30)]
        public string Name { get; set; }
    }
}
