using AutoMapper;
using SalesPlatform.Application.Accounts.Commands.Common;
using SalesPlatform.Application.Products.Queries.Common;
using SalesPlatform.Application.Products.Queries.GetProductBasicDetailBySearchKey;
using SalesPlatform.Domain.Entities;
using SalesPlatform.Domain.ValueObjects;
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
            CreateMap<Product, ProductDetailBySearchKeyViewModel>()
                .ForMember(a => a.ProducerName, opt => opt.MapFrom(src => src.ProductDetails.ProducerName));

            CreateMap<AddressDto, Address>();
            CreateMap<ContactDto, Contact>();
            CreateMap<AccountDto, Account>();
            CreateMap<UserDto, User>()
                .ForPath(a => a.UserName, opt => opt.MapFrom(src => new PersonName(src.FirstName, src.LastName)));
        }
    }
}
