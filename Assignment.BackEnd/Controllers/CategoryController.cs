using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assignment.BackEnd.Models;
using Assignment.BackEnd.Data;
using AutoMapper;
using Assignment.Shared;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;

namespace Assignment.BackEnd.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    //[Authorize("Bearer")]
    public class CategoryController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        private IMapper _mapper;

        public CategoryController(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        [HttpGet]
        [AllowAnonymous]
        public async Task<IEnumerable<CategoryRespone>> GetCate()
        {
            var cate = await _context.Categories.ToListAsync();
            var cateRes = _mapper.Map<IEnumerable<CategoryRespone>>(cate);
            return cateRes;
        }

        [HttpGet("{id}")]
        [AllowAnonymous]
        public async Task<ActionResult<CategoryRespone>> GetCate(string id)
        {
            var cate = await _context.Categories.FindAsync(id);
            var cateRes = _mapper.Map<CategoryRespone>(cate);
            return cateRes;
        }

        [HttpPost()]
        //[Authorize(Roles = "admin")]
        public async Task<ActionResult<CategoryRespone>> CreateCate([FromForm] CategoryRequest request)
        {
            var cate = _mapper.Map<Category>(request);
            _context.Categories.Add(cate);
            await _context.SaveChangesAsync();

            var cateRes = _mapper.Map<CategoryRespone>(cate);
            return cateRes;
        }

        [HttpPut("{id}")]
        //[Authorize(Roles = "admin")]
        public async Task<ActionResult<CategoryRequest>> UpdateCate(string id, [FromForm] CateUpdateRequest updateRequest)
        {
            var cate = await _context.Categories.FindAsync(id);

            if (cate == null)
            {
                return NotFound();
            }

            _context.Entry(cate).CurrentValues.SetValues(updateRequest);

            await _context.SaveChangesAsync();

            var cateRes = _mapper.Map<CategoryRequest>(cate);

            return cateRes;
        }

        [HttpDelete("{id}")]
        //[Authorize(Roles = "admin")]
        public async Task<ActionResult<Category>> DeletCate(string id)
        {
            var cate = await _context.Categories.FindAsync(id);
            _context.Categories.Remove(cate);
            await _context.SaveChangesAsync();
            return Accepted();

        }
    }
}
