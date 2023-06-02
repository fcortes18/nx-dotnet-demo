namespace Shared.InfrastructureUtils;
public interface IRepository<TEntity> where TEntity : class
{
    IEnumerable<TEntity> Get();
    IEnumerable<TEntity> Get(IEnumerable<int> ids);
    void Insert(TEntity entity);
    void Update(TEntity entity);
    void Delete(int id);
}
