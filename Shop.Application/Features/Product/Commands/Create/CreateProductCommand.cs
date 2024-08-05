using MediatR;
using Shop.Domain.Product.Dtos;

namespace Shop.Application.Features.Product.Commands.Create;

public class CreateProductQuery : IRequest<bool>
{
    public CreateProductQuery(CreateProductDto product)
    {
        Product = product;
    }

    public CreateProductDto Product { get; set; }
}