using MediatR;
using Shop.Domain.Product.Contracts;

namespace Shop.Application.Features.Product.Commands.Create;

public class CreateProductCommandHandler : IRequestHandler<CreateProductQuery, bool>
{
    private readonly IProductRepository _productRepository;

    public CreateProductCommandHandler(IProductRepository productRepository)
    {
        _productRepository = productRepository;
    }

    public async Task<bool> Handle(CreateProductQuery request, CancellationToken cancellationToken)
    {
        return await _productRepository.Create(request.Product, cancellationToken);
    }
}