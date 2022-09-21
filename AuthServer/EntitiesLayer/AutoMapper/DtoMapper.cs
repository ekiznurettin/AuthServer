using AutoMapper;
using EntitiesLayer.Concrete;
using EntitiesLayer.Dtos;

namespace EntitiesLayer.AutoMapper
{
    public class DtoMapper : Profile
    {
        public DtoMapper()
        {
            CreateMap<ProductDto, Product>().ReverseMap();
            CreateMap<UserAppDto,UserApp>().ReverseMap();
        }
    }
}
