using ApplicationCore.EF;
using ApplicationCore.Models;
using AutoMapper;

namespace ApplicationCore.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Laptop, laptopModels>();
            CreateMap<laptopModels, Laptop>();

            CreateMap<Cart, cartModels>();
            CreateMap<cartModels, Cart>();

            CreateMap<Cartdetail, cartdetailModels>();
            CreateMap<cartdetailModels, Cartdetail>();

            CreateMap<Promotion, promotionModels>();
            CreateMap<promotionModels, Promotion>();

            CreateMap<Userinformation, accountModels>();
            CreateMap<accountModels, Userinformation>();
        }
    }
}
