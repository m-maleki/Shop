using Microsoft.AspNetCore.Identity;

namespace Shop.Domain.User.Entities;

public class ApplicationUser : IdentityUser<int>
{
    public List<Product.Entities.Product>? Products { get; set; }
}