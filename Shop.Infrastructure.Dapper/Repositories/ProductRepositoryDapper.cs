using Dapper;
using Microsoft.Data.SqlClient;
using Shop.Domain.Product.Dtos;
using Shop.Domain.Product.Contracts;
using Microsoft.Extensions.Configuration;
using Shop.Infrastructure.Dapper.Queries;

namespace Shop.Infrastructure.Dapper.Repositories;

public class ProductRepositoryDapper : IProductRepositoryDapper
{
    private readonly string? _connectionString;

    public ProductRepositoryDapper(IConfiguration configuration)
    {
        _connectionString = configuration["ConnectionStrings:ConnectionString"];
    }

    public async Task<List<GetProductDto>> GetAll(CancellationToken cancellationToken)
    {
        await using var connection = new SqlConnection(_connectionString);
        await connection.OpenAsync(cancellationToken);

        var result = await connection.QueryAsync<GetProductDto>(ProductQueries.GetAll, cancellationToken);
        return result.ToList();
    }

    public async Task<GetProductDto> GetById(int id, CancellationToken cancellationToken)
    {
        await using var connection = new SqlConnection(_connectionString);
        await connection.OpenAsync(cancellationToken);

        var parameters = new { Id = id };
        var products = await connection.QueryFirstOrDefaultAsync<GetProductDto>(ProductQueries.GetById, parameters);

        if (products is not null)
            return products;

        throw new Exception("No product find in database");
    }
}