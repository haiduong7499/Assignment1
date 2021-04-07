using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assignment.Shared;
using Assignment.BackEnd.Models;

namespace Assignment.BackEnd.Mappings
{
    public class CateProfile:Profile
    {
        public CateProfile()
        {
            CreateMap<CategoryRespone, Category>().ReverseMap();
            CreateMap<CategoryRequest, Category>().ReverseMap();
        }
    }
}
