using Assignment.BackEnd.Models;
using Assignment.Shared;
using AutoMapper;
namespace Assignment.BackEnd.Mappings
{
    public class ProductProfile:Profile
    {
        public ProductProfile()
        {
            CreateMap<ProductRespone, Product>().ForPath(p => p.Category.Name, pm => pm.MapFrom(o => o.NameCategory))
                .ReverseMap();
            CreateMap<ProductRequest, Product>().ReverseMap();
        }
    }
}
