using AutoMapper;
using System;
using System.Linq;
using TradingCompany.DTO;

namespace DAL.Profiles
{
    public class ProductProfile : Profile
    {
        public ProductProfile()
        {
            CreateMap<Post, PostDTO>();

            CreateMap<Product, ProductDTO>()
                .ForMember(dest => dest.Posts,
                src => src.MapFrom(p => p.PostProducts.Select(pp => pp.Post)));

            CreateMap<ProductDTO, Product>()
                .ForMember(dest => dest.PostProducts,
                src => src.MapFrom(p => p.Posts.Select(pp => new PostProduct
                {
                    ProductID = p.ProductID,
                    PostID = pp.PostID,
                    RowInsertTime = DateTime.UtcNow
                })));
        }
    }
}
