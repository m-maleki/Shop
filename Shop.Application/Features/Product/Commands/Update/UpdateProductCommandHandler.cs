using MediatR;
using Shop.Domain.Product.Contracts;

namespace Shop.Application.Features.Product.Commands.Update;

public class UpdateProductCommandHandler : IRequestHandler<UpdateProductCommand, bool>
{
    private readonly IProductRepository _productRepository;

    public UpdateProductCommandHandler(IProductRepository productRepository)
    {
        _productRepository = productRepository;
    }

    public async Task<bool> Handle(UpdateProductCommand request, CancellationToken cancellationToken)
    {
        return await _productRepository.Update(request.Product, cancellationToken);
    }
}