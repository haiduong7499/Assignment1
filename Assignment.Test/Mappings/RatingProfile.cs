using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assignment.BackEnd.Models;
using Assignment.Shared;
using AutoMapper;

namespace Assignment.BackEnd.Mappings
{
    public static class RatingProfile
    {
        public static IMapper Get()
        {
            var config = new MapperConfiguration(cfg =>
            {

                cfg.CreateMap<RatingRespone, Rating>().ReverseMap();
                cfg.CreateMap<RatingRequest, Rating>().ReverseMap();

            });

            return config.CreateMapper();
        }
    }
}
