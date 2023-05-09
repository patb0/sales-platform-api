using AutoMapper;
using SalesPlatform.Application.Accounts.Commands.Common;
using SalesPlatform.Application.Opinions.Queries.GetOpinionsByProductId;
using SalesPlatform.Application.Products.Commands.AddProduct;
using SalesPlatform.Application.Products.Queries.GetProductBasicDetailBySearchKey;
using SalesPlatform.Application.Products.Queries.ViewModel;
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
            //product queries
            CreateMap<Product, ProductFullDetailViewModel>()
                .ForMember(a => a.ProducerName, opt => opt.MapFrom(src => src.ProductDetail.ProducerName))
                .ForMember(b => b.Color, opt => opt.MapFrom(src => src.ProductDetail.Color))
                .ForMember(c => c.Country, opt => opt.MapFrom(src => src.ProductDetail.Country));

            CreateMap<Product, ProductBasicDetailViewModel>();
            CreateMap<Product, ProductDetailBySearchKeyViewModel>()
                .ForMember(a => a.ProducerName, opt => opt.MapFrom(src => src.ProductDetail.ProducerName));

            //product commands
            CreateMap<AddProductDto, Product>()
                .ForPath(a => a.ProductDetail, opt => opt.MapFrom(src => 
                    new ProductDetail(src.ProducerName, src.Country, src.Color)));

            //register user
            CreateMap<AddressDto, Address>();
            CreateMap<ContactDto, Contact>();
            CreateMap<AccountDto, Account>();
            CreateMap<UserDto, User>()
                .ForPath(a => a.UserName, opt => opt.MapFrom(src => new PersonName(src.FirstName, src.LastName)));

            //product opinions
            CreateMap<Opinion, OpinionViewModel>();
        }
    }
}
