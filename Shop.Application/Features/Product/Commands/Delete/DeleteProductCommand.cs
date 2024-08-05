using MediatR;

namespace Shop.Application.Features.Product.Commands.Delete;

public class DeleteProductCommand : IRequest<bool>
{
    public DeleteProductCommand(int productId)
    {
        ProductId = productId;
    }

    public int ProductId { get; set; }
}