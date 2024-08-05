using MediatR;
using Shop.Domain.Product.Dtos;
using Shop.Domain.Product.Contracts;

namespace Shop.Application.Features.Product.Queries.GetById;

public class GetByIdProductQueryHandler : IRequestHandler<GetProductByIdQuery, GetProductDto>
{
    private readonly IProductRepository _productRepository;

    public GetByIdProductQueryHandler(IProductRepository productRepository)
    {
        _productRepository = productRepository;
    }

    public async Task<GetProductDto> Handle(GetProductByIdQuery request, CancellationToken cancellationToken)
    {
        return await _productRepository.Get(request.ProductId, cancellationToken);
    }
}