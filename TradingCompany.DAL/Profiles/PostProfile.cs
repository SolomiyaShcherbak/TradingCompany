using AutoMapper;
using System;
using System.Linq;
using TradingCompany.DTO;

namespace DAL.Profiles
{
    public class PostProfile : Profile
    {
        public PostProfile()
        {
            CreateMap<Product, ProductDTO>();

            CreateMap<Post, PostDTO>()
                .ForMember(dest => dest.Products,
                src => src.MapFrom(p => p.PostProducts.Select(pp => pp.Product).ToList()));

            CreateMap<PostDTO, Post>()
                .ForMember(dest => dest.PostProducts,
                src => src.MapFrom(p => p.Products.Select(pp => new PostProduct
                {
                    PostID = p.PostID,
                    ProductID = pp.ProductID,
                    RowInsertTime = DateTime.UtcNow
                })));
        }
    }
}
