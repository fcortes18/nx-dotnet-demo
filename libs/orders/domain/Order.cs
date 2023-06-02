using Shared.Framework;

namespace Orders.Domain;
public class Order : Entity
{
    public decimal Subtotal { get; set; }
    public List<OrderItem>? Items { get; set;}
}