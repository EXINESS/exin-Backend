using backend.Domain.Contracts;
namespace backend.Application.Contracts
{
    public interface IRepository<TKey, TEntity>
        where TEntity : IEntity<TKey>
    {

        Task<TEntity> AddAsync(TEntity entity);
        Task<TEntity?> GetByIdAsync(TKey id);
        Task UpdateAsync(TEntity entity);
        Task DeleteAsync(TEntity entity);

    }
}
