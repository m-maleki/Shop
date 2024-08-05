using Shop.Domain.User.Entities;
using Shop.Domain.Product.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Shop.Infrastructure.EfCore.Configurations;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace Shop.Infrastructure.EfCore.Common;

public class AppDbContext : IdentityDbContext<ApplicationUser, IdentityRole<int>, int>
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {

    }
    public DbSet<Product> Products { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.ApplyConfiguration(new ProductEntityConfiguration());

        base.OnModelCreating(builder);
    }
}