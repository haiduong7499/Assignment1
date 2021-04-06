<<<<<<< HEAD
﻿using Assignment.BackEnd.Data;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Assignment.Shared;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Assignment.BackEnd.Models;
using System;

namespace Assignment.BackEnd.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize("Bearer")]
=======
﻿using Microsoft.AspNetCore.Mvc;
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
>>>>>>> a7c890a9e6622adff040cb2b29ff8a33389a8aa1
    public class ProductController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        private IMapper _mapper;
<<<<<<< HEAD
        public ProductController(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        [HttpGet]
        [AllowAnonymous]
        public async Task<IEnumerable<ProductRespone>> GetProduct()
        {
            var product = await _context.Products.ToListAsync();
            var productRes = _mapper.Map<IEnumerable<ProductRespone>>(product);

            return productRes;
        }
        [HttpGet("{id}")]
        [AllowAnonymous]
        public async Task<ActionResult<ProductRespone>> GetProduct(string id)
        {
            var product = await _context.Products.FindAsync(id);
            if (product == null)
            {
                return NotFound();
            }

=======
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
>>>>>>> a7c890a9e6622adff040cb2b29ff8a33389a8aa1
            var productRes = _mapper.Map<ProductRespone>(product);

            return productRes;
        }
<<<<<<< HEAD
        [HttpPut("{id}")]
        [Authorize(Roles = "admin")]
        public async Task<ActionResult<ProductRequest>> UpdateProduct(string id,[FromForm] ProductUpdateRequest updateRequest)
        {
            var product = await _context.Products.FindAsync(id);

            if (product == null)
            {
                return NotFound();
            }

            _context.Entry(product).CurrentValues.SetValues(updateRequest);
            product.UpdateDate = DateTime.Now.Date;

            await _context.SaveChangesAsync();

            var productRes = _mapper.Map<ProductRequest>(product);

            return productRes;
        }
        [HttpPost("{id}")]
        [Authorize(Roles = "admin")]
        public async Task<ActionResult<ProductRespone>> CreateProduct([FromForm]ProductRequest request)
        {
            var product = _mapper.Map<Product>(request);
            product.ProductId = Guid.NewGuid().ToString();
            product.CreateDate = DateTime.Now;
            product.UpdateDate = DateTime.Now;
            _context.Products.Add(product);
            await _context.SaveChangesAsync();

            var productRes = _mapper.Map<ProductRespone>(product);
            return productRes;
        }

        [HttpDelete("{id}")]
        [Authorize(Roles = "admin")]
        public async Task<ActionResult<ProductRespone>> DeleteProduct(string id)
        {
            var product = await _context.Products.FindAsync(id);
            _context.Products.Remove(product);
            await _context.SaveChangesAsync();
            return NoContent();
        }
=======
>>>>>>> a7c890a9e6622adff040cb2b29ff8a33389a8aa1
    }
}
