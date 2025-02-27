using AutoMapper;
using Entities.Dtos;
using Entities.Models;
using Microsoft.AspNetCore.Identity;

namespace ShopApp.Infrastructure.Mapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<ProductDtoForInsertion, Product>();
            CreateMap<ProductDtoForUpdate, Product>().ReverseMap();
            CreateMap<UserDtoForCreation, IdentityUser>();
            CreateMap<UserDtoForUpdate, IdentityUser>().ReverseMap();

        }
    }
}
