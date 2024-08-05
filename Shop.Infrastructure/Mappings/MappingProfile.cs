using AutoMapper;
using Shop.Domain.Product.Dtos;
using Shop.Domain.Product.Entities;

namespace Shop.Infrastructure.EfCore.Mappings;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<Product, GetProductDto>().ReverseMap();
        CreateMap<Product, CreateProductDto>().ReverseMap();
    }
}