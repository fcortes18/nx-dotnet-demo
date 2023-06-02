using Shared.Framework;

namespace Shared.InfrastructureUtils;
public class Repository<TEntity> : IRepository<TEntity>
 where TEntity : Entity
{
  //TODO: replace for db context instead, it's just for demo :)
  private readonly IList<TEntity> _items;

  public Repository(IList<TEntity> items) 
  {
    _items = items;
  }

  public IEnumerable<TEntity> Get()
  {
    return _items;
  }

  public IEnumerable<TEntity> Get(IEnumerable<int> ids)
  {
    if (ids == null || !ids.Any()) return new List<TEntity>();
    return _items.Where(i => ids.Contains(i.Id));
  }

  public TEntity? Get(int id)
  {
    return _items.FirstOrDefault(i => i.Id == id);
  }

  public void Insert(TEntity entity)
  {
    if (entity == null) return;
    _items.Add(entity);
  }

  public void Update(TEntity entity)
  {
    if (entity == null) return;
    var oldEntity = Get(entity.Id);
    if (oldEntity == null) return;
    oldEntity = entity;
  }

  public void Delete(int id)
  {
    var entity = Get(id);
    if (entity == null) return;
    _items.Remove(entity);
  }
}
