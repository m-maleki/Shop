namespace Shop.Domain.Product.Dtos;

public class UpdateProductDto
{
    public int Id { get; set; }
    public string Name { get; set; }
    public bool IsAvailable { get; set; }
    public string ManufacturePhone { get; set; }
}