using Assignment.BackEnd.Models;
using Assignment.Shared;
using AutoMapper;
namespace Assignment.BackEnd.Mappings
{
    public class ProductProfile:Profile
    {
        public ProductProfile()
        {
            CreateMap<Product, ProductRespone>().ReverseMap();
            CreateMap<Product, ProductRequest>().ReverseMap();
        }
    }
}
