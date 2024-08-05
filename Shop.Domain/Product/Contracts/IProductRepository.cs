using Shop.Domain.Product.Dtos;

namespace Shop.Domain.Product.Contracts;

public interface IProductRepository
{
    Task<bool> Create(CreateProductDto model, CancellationToken cancellationToken);
    Task<GetProductDto> Get(int id, CancellationToken cancellationToken);
    Task<List<GetProductDto>> GetAll(CancellationToken cancellationToken);
    Task<bool> Delete(int productId, CancellationToken cancellationToken);
    Task<bool> Update(UpdateProductDto model, CancellationToken cancellationToken);
}