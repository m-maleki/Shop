namespace Shop.Domain.Product.Dtos;

public class CreateProductDto
{
    public string Name { get; set; }

    public string ManufactureEmail { get; set; }

    public string ManufacturePhone { get; set; }

    public int UserId { get; set; }
}