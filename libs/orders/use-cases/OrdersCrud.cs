using Orders.Domain;
using Orders.Infrastructure;

namespace Orders.UseCases;
public class OrdersCrud : IOrdersCrud
{
    private readonly IOrdersRepository _repository;
    public OrdersCrud() 
    {
        //TODO: just for the demo, not real data or good implementation
        var orders = new List<Order>();
        var items = new List<OrderItem>();
        items.Add(new OrderItem() {
            Id = 1,
            OrderId = 1,
            ProductId = 1,
            Count = 1
        });
        var order = new Order() {
            Id = 1,
            Subtotal = 10,
            Items = items
        };
        orders.Add(order);
        _repository = new OrdersRepository(orders);
    }

    public void Delete(int id)
    {
        _repository.Delete(id);
    }

    public IEnumerable<Order> Get()
    {
        return _repository.Get();
    }

    public IEnumerable<Order> Get(IEnumerable<int> ids)
    {
        return _repository.Get(ids);
    }

    public void Insert(Order entity)
    {
        _repository.Insert(entity);
    }

    public void Update(Order entity)
    {
        _repository.Update(entity);
    }
}
