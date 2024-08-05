using MediatR;
using Shop.Domain.Product.Dtos;

namespace Shop.Application.Features.Product.Commands.Update;

public class UpdateProductCommand : IRequest<bool>
{
    public UpdateProductCommand(UpdateProductDto product)
    {
        Product = product;
    }

    public UpdateProductDto Product { get; set; }
}