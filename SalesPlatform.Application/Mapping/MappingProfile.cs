using AutoMapper;
using SalesPlatform.Application.Products.Queries.Common;
using SalesPlatform.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesPlatform.Application.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Product, ProductFullDetailViewModel>()
                .ForMember(a => a.ProducerName, opt => opt.MapFrom(src => src.ProductDetails.ProducerName))
                .ForMember(b => b.Color, opt => opt.MapFrom(src => src.ProductDetails.Color))
                .ForMember(c => c.Country, opt => opt.MapFrom(src => src.ProductDetails.Country));

            CreateMap<Product, ProductBasicDetailViewModel>();
        }
    }
}
