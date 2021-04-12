using Assignment.BackEnd.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment.BackEnd.Controllers
{
    public class Rating : Controller
    {
        //private readonly ApplicationDbContext _context;
        //public Rating(ApplicationDbContext context)
        //{
        //    _context = context;
        //}

        //public async Task<Rating>
        public IActionResult Index()
        {
            return View();
        }
    }
}
