using MediatR;
using Shop.Domain.Product.Dtos;

namespace Shop.Application.Features.Product.Queries.GetAll;

public class GetAllProductQuery : IRequest<List<GetProductDto>>
{
}