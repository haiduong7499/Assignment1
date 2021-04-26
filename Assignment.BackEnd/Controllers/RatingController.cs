using Assignment.BackEnd.Data;
using Assignment.BackEnd.Models;
using Assignment.Shared;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment.BackEnd.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize("Bearer")]
    public class RatingController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;

        public RatingController(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        [HttpGet]
        [AllowAnonymous]
        public async Task<IEnumerable<RatingRespone>> GetRatings()
        {
            var rate = await _context.Ratings.Include(rate => rate.ProductId).AsNoTracking()
                .ToListAsync();
            var rateRes = _mapper.Map<IEnumerable<RatingRespone>>(rate);
            return rateRes;
        }

        [HttpGet("{id}")]
        [AllowAnonymous]
        public async Task<IEnumerable<RatingRespone>> GetRating(string id)
        {
            var rate = await _context.Ratings
                .Include(rate => rate.Product)
                .Where(rate=> rate.ProductId.Equals(id))
                .AsNoTracking()
                .ToListAsync();
            var rateRes = _mapper.Map<IEnumerable<RatingRespone>>(rate);
            return rateRes;
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<ActionResult<RatingRespone>> CreateRating(RatingRequest request)
        {
            var rate = _mapper.Map<Rating>(request);
            _context.Ratings.Add(rate);
            rate.PublishDate = DateTime.Now;
            await _context.SaveChangesAsync();

            var sumRating = _context.Ratings.Where(x => x.ProductId.Equals(rate.ProductId)).Average(p => p.Rate);
            var product = await _context.Products.FindAsync(rate.ProductId);
            product.Rate = Convert.ToInt32(sumRating);
            await _context.SaveChangesAsync();
            var rateRes = _mapper.Map<RatingRespone>(rate);
            return rateRes;
        }
    }
}
