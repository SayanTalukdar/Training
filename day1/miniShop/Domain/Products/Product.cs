namespace Domain.Products;

public class Product
{
    public Guid Id { get; private set; }

    public string Name { get; private set; } = string.Empty;

    public decimal Price { get; private set; }
}
