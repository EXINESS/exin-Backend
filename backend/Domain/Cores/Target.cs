using backend.Domain.Cores;
using backend.Domain.Contracts;
namespace backend.Domain.Cores
{
    public class Target: Entity<int>
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public readonly List<SubTask> subTasks;

    }
}
