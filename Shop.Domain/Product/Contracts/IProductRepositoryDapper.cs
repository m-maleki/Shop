using Shop.Domain.Product.Dtos;

namespace Shop.Domain.Product.Contracts;

public interface IProductRepositoryDapper
{
    Task<List<GetProductDto>> GetAll(CancellationToken cancellationToken);
    Task<GetProductDto> GetById(int id, CancellationToken cancellationToken);
}