using Shop.Domain.User.Entities;

namespace Shop.Domain.Product.Entities;

public class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public bool IsAvailable { get; set; }
    public string ManufactureEmail { get; set; }
    public string ManufacturePhone { get; set; }
    public DateTime ProduceDate { get; set; }
    public ApplicationUser ApplicationUser { get; set; }
    public int UserId { get; set; }
}