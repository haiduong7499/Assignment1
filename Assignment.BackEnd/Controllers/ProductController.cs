using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assignment.BackEnd.Data;
using Assignment.Shared;
using Microsoft.AspNetCore.Authorization;
using AutoMapper;
using Microsoft.EntityFrameworkCore;

namespace Assignment.BackEnd.Controllers
{
    public class ProductController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        private IMapper _mapper;
        public ProductController(ApplicationDbContext context, IMapper mapper) {
            _context = context;
            _mapper = mapper;
        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<IEnumerable<ProductRespone>> GetProducts()
        {
            var product = await _context.Products.ToListAsync();
            var productRes = _mapper.Map<IEnumerable<ProductRespone>>(product);
            return productRes;
        }

        [HttpGet("{id}")]
        [AllowAnonymous]
        public async Task<ActionResult<ProductRespone>> GetProduct(int id) {
            var product = await _context.Products.FindAsync(id);
            if(product == null)
            {
                return NotFound();
            }
            var productRes = _mapper.Map<ProductRespone>(product);

            return productRes;
        }
    }
}
