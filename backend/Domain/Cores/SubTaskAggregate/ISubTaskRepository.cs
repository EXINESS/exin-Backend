using backend.Domain.Cores.TargetAggregate;
using backend.Domain.Cores.TokenAggregate;
namespace backend.Domain.Cores.SubTaskAggregate
{
    public interface ISubTaskRepository
    {
        Task<SubTask> AddSubTaskAsync(SubTask subTask, Token token);
        Task<SubTask?> GetSubTaskByIdAsync(Guid guid, Token token);
        Task EditeSubTaskAsync(Guid guid, Token token);
        Task DeleteSubTaskAsync(Guid guid, Token token);
        Task CheckStatusTaskAsync(Guid guid);
    }
}
