using Orders.Domain;
using Shared.InfrastructureUtils;

namespace Orders.Infrastructure;
public class OrdersRepository : Repository<Order>, IOrdersRepository
{
  public OrdersRepository(IList<Order> items) : base(items)
  {
  }
}
