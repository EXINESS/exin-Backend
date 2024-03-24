using backend.Domain.Cores.AchiveAggregate;
using backend.Domain.Cores.TokenAggregate;

namespace backend.Domain.Cores.AchiveAggregate
{
    public interface IAchiveRepository
    {
        Task<Achive> AddAchiveAsync(Achive achive, Token token);
        Task<Achive?> GetAchiveByIdAsync(Guid id, Token token);
        Task EditeAchiveAsync(Guid guid, Token token);
        Task DeleteAchiveAsync(Guid Id, Token token);
    }
}
