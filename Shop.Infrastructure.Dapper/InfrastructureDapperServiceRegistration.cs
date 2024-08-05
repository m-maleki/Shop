using Shop.Domain.Product.Contracts;
using Shop.Infrastructure.Dapper.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace Shop.Infrastructure.Dapper;

public static class InfrastructureDapperServiceRegistration
{
    public static IServiceCollection AddInfrastructureDapperServices(this IServiceCollection services)
    {
        services.AddScoped<IProductRepositoryDapper, ProductRepositoryDapper>();
        return services;
    }
}