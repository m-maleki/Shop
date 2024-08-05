using MediatR;
using Shop.Domain.Product.Dtos;

namespace Shop.Application.Features.Product.Queries.GetById;

public class GetProductByIdQuery : IRequest<GetProductDto>
{
    public GetProductByIdQuery(int productId)
    {
        ProductId = productId;
    }

    public int ProductId { get; set; }
}