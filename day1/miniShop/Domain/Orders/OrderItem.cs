using Domain.Products;

namespace Domain.Orders;

public class OrderItem
{
    internal OrderItem(Guid id, Guid orderId, Guid productId, decimal price)
    {
        Id = id;
        OrderId = orderId;
        ProductId = productId;
        TotalAmount = price;
    }

    public Guid Id { get; private set; }

    public Guid OrderId { get; private set; }

    public Guid ProductId { get; private set; }

    public decimal TotalAmount { get; private set; }
}