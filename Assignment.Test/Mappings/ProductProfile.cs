using Assignment.BackEnd.Models;
using Assignment.Shared;
using AutoMapper;
namespace Assignment.BackEnd.Mappings
{
    public static class ProductProfile
    {
        public static IMapper Get()
        {
            var config = new MapperConfiguration(cfg =>
            {

                cfg.CreateMap<ProductRespone, Product>().ForPath(p => p.Category.Name, pm => pm.MapFrom(o => o.NameCategory))
                    .ReverseMap();
                cfg.CreateMap<ProductRequest, Product>().ReverseMap();

            });

            return config.CreateMapper();
        }
    }
}
