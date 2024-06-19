using Domain.Customers;
using Domain.Products;

namespace Domain.Orders;

public class Order
{
    private readonly HashSet<OrderItem> _orderItems = new();

    private Order()
    {
    }

    public Guid Id { get; private set; }

    public Guid CustomerId { get; private set; }

    public static Order Create(Customer customer)
    {
        var order = new Order
        {
            Id = Guid.NewGuid(),
            CustomerId = customer.Id
        };

        return order;
    }

    public void Add(Product product)
    {
        var item = new OrderItem(Guid.NewGuid(), Id, product.Id, product.Price);

        _orderItems.Add(item);
    }
}