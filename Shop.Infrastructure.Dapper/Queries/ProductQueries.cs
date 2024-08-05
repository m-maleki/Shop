namespace Shop.Infrastructure.Dapper.Queries;

public static class ProductQueries
{
    public static string GetAll =
        "SELECT Id,Name,IsAvailable,ManufactureEmail,ManufacturePhone,ProduceDate FROM Products";

    public static string GetById =
        "SELECT Id,Name,IsAvailable,ManufactureEmail,ManufacturePhone,ProduceDate FROM Products WHERE Id = @Id";
}