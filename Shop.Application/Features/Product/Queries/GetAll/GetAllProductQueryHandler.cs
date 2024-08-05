using MediatR;
using Shop.Domain.Product.Dtos;
using Shop.Domain.Product.Contracts;

namespace Shop.Application.Features.Product.Queries.GetAll;

public class GetAllProductQueryHandler : IRequestHandler<GetAllProductQuery, List<GetProductDto>>
{
    private readonly IProductRepositoryDapper _productRepositoryDapper;

    public GetAllProductQueryHandler(IProductRepositoryDapper productRepositoryDapper)
    {
        _productRepositoryDapper = productRepositoryDapper;
    }

    public async Task<List<GetProductDto>> Handle(GetAllProductQuery request, CancellationToken cancellationToken)
    {
        return await _productRepositoryDapper.GetAll(cancellationToken);
    }
}