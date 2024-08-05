using System.Reflection;
using Microsoft.EntityFrameworkCore;
using Shop.Domain.Product.Contracts;
using Shop.Infrastructure.EfCore.Common;
using Microsoft.Extensions.Configuration;
using Shop.Infrastructure.EfCore.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace Shop.Infrastructure.EfCore;

public static class InfrastructureEfCoreServiceRegistration
{
    public static IServiceCollection AddInfrastructureEfCoreServices(this IServiceCollection services,
        IConfiguration configuration)
    {
        services.AddDbContext<AppDbContext>(options =>
            options.UseSqlServer(configuration.GetConnectionString("ConnectionString")));

        services.AddScoped<IProductRepository, ProductRepository>();

        services.AddAutoMapper(Assembly.GetExecutingAssembly());

        return services;
    }
}