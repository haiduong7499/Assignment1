using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assignment.BackEnd.Models;
using Assignment.Shared;
using AutoMapper;

namespace Assignment.BackEnd.Mappings
{
    public class RatingProfile : Profile
    {
        public RatingProfile()
        {
            CreateMap<RatingRespone, Rating>().ForPath(p => p.Product.ProductId, pm => pm.MapFrom(o => o.ProductID))
                .ReverseMap();
            CreateMap<RatingRequest, Rating>().ReverseMap();

        }
    }
}
