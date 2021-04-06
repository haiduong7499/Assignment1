using Assignment.BackEnd.Models;
<<<<<<< HEAD
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
=======
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
>>>>>>> a7c890a9e6622adff040cb2b29ff8a33389a8aa1
        }
    }
}
