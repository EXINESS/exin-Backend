using backend.Domain.Cores.TokenAggregate;

namespace backend.Domain.Cores.TargetAggregate
{
    public interface ITargetRepository
    {
        Task<Target> AddTargetAsync(Target target,Token token);
        Task<Target?> GetTargetByIdAsync(Guid guid,Token token);
        Task EditeTargetAsync( Guid guid,Token token);
        Task DeleteTargetAsync(Guid targetId,Token token);
    }
}
