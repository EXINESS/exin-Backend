using backend.Domain.Contracts;
namespace backend.Domain.Cores
{
    public class Entity<TKey> : IEntity<TKey>
    {
        public TKey Id { get; set; }
    }
}
