using Assignment.BackEnd.Models;
using AutoMapper;
using Assignment.Shared;


namespace Assignment.BackEnd.Mappings
{
    public class ProductProfile : Profile
    {
        public ProductProfile()
        {
            CreateMap<ProductRequest, Product>().ReverseMap();
            CreateMap<ProductRespone, Product>()
                .ReverseMap();
        }
    }
}
