using Orders.Domain;

namespace Orders.UseCases;
public interface IOrdersCrud
{
    IEnumerable<Order> Get();
    IEnumerable<Order> Get(IEnumerable<int> ids);
    void Insert(Order entity);
    void Update(Order entity);
    void Delete(int id);
}
