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
using Assignment.BackEnd.Services;
using System.IO;
using System.Net.Http.Headers;
using System;
using Microsoft.AspNetCore.Http;

namespace Assignment.BackEnd.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize("Bearer")]
    public class ProductController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        private readonly IStorageService _storageService;
        private readonly IMapper _mapper;
        public ProductController(ApplicationDbContext context, IMapper mapper, IStorageService storageService)
        {
            _context = context;
            _mapper = mapper;
            _storageService = storageService;
        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<IEnumerable<ProductRespone>> GetProduct()
        {
            var product = await _context.Products
                .Include(product => product.Category)
                .AsNoTracking()
                .ToListAsync();
            foreach (var item in product)
            {
                item.ProductImg = _storageService.GetFileUrl(item.ProductImg);
            }
            var productRes = _mapper.Map<IEnumerable<ProductRespone>>(product);
            return productRes;
        }
        [HttpGet("{id}")]
        [AllowAnonymous]
        public async Task<ActionResult<ProductRespone>> GetProduct(string id)
        {
            var product = await _context.Products.FindAsync(id);
            product.ProductImg = _storageService.GetFileUrl(product.ProductImg);

            if (product == null)
            {
                return NotFound();
            }

            var productRes = _mapper.Map<ProductRespone>(product);

            return productRes;
        }

        [HttpGet("GetProductByID/{id}")]
        [AllowAnonymous]
        public async Task<ActionResult<ProductRespone>> GetProductByID(string id)
        {
            var product = await _context.Products.Include(product => product.Category)
                .Where(product => product.ProductId.Equals(id))
                .AsNoTracking()
                .SingleAsync();
            if (product == null)
            {
                return NotFound();
            }
            product.ProductImg = _storageService.GetFileUrl(product.ProductImg);
            var productRes = _mapper.Map<ProductRespone>(product);
            productRes.NameCategory = product.Category.Name;
            return productRes;
        }


        [HttpGet("GetProductByCategory/{categoryId}")]
        [AllowAnonymous]
        public async Task<IEnumerable<ProductRespone>> GetProductByCategory(string categoryId)
        {
            var products = await _context.Products
                .Include(p => p.Category)
                .Where(p => p.CategoryID.Equals(categoryId))
                .AsNoTracking()
                .ToListAsync();

            foreach (var item in products)
            {
                item.ProductImg = _storageService.GetFileUrl(item.ProductImg);
            }

            var productRes = _mapper.Map<IEnumerable<ProductRespone>>(products);

            return productRes;
        }


        [HttpPut("{id}")]
        //[Authorize(Roles = "admin")]
        public async Task<ActionResult<ProductRespone>> UpdateProduct(string id, [FromForm] ProductUpdateRequest updateRequest)
        {
            var product = await _context.Products.FindAsync(id);

            _context.Entry(product).CurrentValues.SetValues(updateRequest);
            product.UpdateDate = DateTime.Now.Date;

            await _context.SaveChangesAsync();

            var productRes = _mapper.Map<ProductRespone>(product);

            return productRes;
        }
        [HttpPost]
        //[Authorize(Roles = "admin")]
        [AllowAnonymous]
        public async Task<ActionResult<ProductRespone>> CreateProduct([FromForm] ProductRequest request)
        {
            var product = _mapper.Map<Product>(request);
            if (product == null)
            {
                return NotFound();
            }

            if (request.ProductImg != null)
            {
                product.ProductImg = await SaveFile(request.ProductImg);
            }
            else
            {
                product.ProductImg = "add.jpg";
            }

            product.ProductId = Guid.NewGuid().ToString();
            product.CreateDate = DateTime.Now;
            product.UpdateDate = DateTime.Now;
            _context.Products.Add(product);
            await _context.SaveChangesAsync();

            var productRes = _mapper.Map<ProductRespone>(product);
            productRes.ProductImg = _storageService.GetFileUrl(productRes.ProductImg);
            return productRes;
        }

        [HttpDelete("{id}")]
        //[Authorize(Roles = "admin")]
        [AllowAnonymous]
        public async Task<ActionResult<ProductRespone>> DeleteProduct(string id)
        {
            var product = await _context.Products.FindAsync(id);
            _context.Products.Remove(product);
            await _context.SaveChangesAsync();
            return NoContent();
        }

        private async Task<string> SaveFile(IFormFile file)
        {
            var originalFileName = ContentDispositionHeaderValue.Parse(file.ContentDisposition).FileName.Trim('"');
            var fileName = $"{Guid.NewGuid()}{Path.GetExtension(originalFileName)}";
            await _storageService.SaveFileAsync(file.OpenReadStream(), fileName);

            return fileName;
        }
    }
}
