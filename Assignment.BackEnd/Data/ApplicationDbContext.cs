using Assignment.BackEnd.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment.BackEnd.Data
{
    public class ApplicationDbContext : IdentityDbContext<User>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
<<<<<<< HEAD
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
=======

        public DbSet<Brand> Brands { get; set; }
        public DbSet<Product> Products { get; set; }
>>>>>>> a7c890a9e6622adff040cb2b29ff8a33389a8aa1
    }
}
