using Assignment.BackEnd.Data;
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
    public class ProductController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        private IMapper _mapper;
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

            var productRes = _mapper.Map<ProductRespone>(product);

            return productRes;
        }
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
        [HttpPost]
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
    }
}
