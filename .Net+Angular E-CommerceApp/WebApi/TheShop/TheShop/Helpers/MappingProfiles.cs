using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheShop.Domain.Models;
using TheShop.DTOs;
using TheShop.Helpers;

namespace TheShop.Mappers.Helpers
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<Product, ProductToReturnDto>()
               .ForMember(d => d.ProductBrand, o => o.MapFrom(s => s.ProductBrand.Name))
               .ForMember(d => d.ProductType, o => o.MapFrom(s => s.ProductType.Name))
               .ForMember(d => d.PictureUrl, o => o.MapFrom<ProductUrlResolver>());
        }
    }
}
