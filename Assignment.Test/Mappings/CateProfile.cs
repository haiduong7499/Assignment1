using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assignment.Shared;
using Assignment.BackEnd.Models;

namespace Assignment.BackEnd.Mappings
{
    public static class CateProfile
    {
        public static IMapper Get()
        {
            var config = new MapperConfiguration(cfg =>
            {

                cfg.CreateMap<CategoryRespone, Category>().ReverseMap();
                cfg.CreateMap<CategoryRequest, Category>().ReverseMap();

            });

            return config.CreateMapper();
        }
    }
}
