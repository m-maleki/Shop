using Shop.Domain.Product.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Shop.Infrastructure.EfCore.Configurations;

public class ProductEntityConfiguration : IEntityTypeConfiguration<Product>
{
    public void Configure(EntityTypeBuilder<Product> builder)
    {
        builder.Property(x => x.Id).ValueGeneratedOnAdd();

        builder.HasKey(c => new { c.ManufactureEmail, c.ProduceDate });

        builder.Property(x => x.Name).IsRequired().HasMaxLength(50);
        builder.Property(x => x.ManufactureEmail).IsRequired().HasMaxLength(50);
        builder.Property(x => x.ManufacturePhone).IsRequired().HasMaxLength(13);

        builder.HasOne(x => x.ApplicationUser)
            .WithMany(x => x.Products)
            .HasForeignKey(x => x.UserId);
    }
}