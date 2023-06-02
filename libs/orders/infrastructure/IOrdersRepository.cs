using Orders.Domain;
using Shared.InfrastructureUtils;

namespace Orders.Infrastructure;
public interface IOrdersRepository : IRepository<Order> 
{
}