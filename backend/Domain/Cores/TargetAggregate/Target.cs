using backend.Domain.Contracts;
using backend.Domain.Cores.SubTaskAggregate;
namespace backend.Domain.Cores.TargetAggregate
{
    public class Target : Entity<int>
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public readonly List<SubTask> subTasks;

        public Target()
        {
            subTasks = new List<SubTask>();
        }
        public void AddSubTask(SubTask subTask)
        {
            subTasks.Add(subTask);
        }

        public void RemoveSubTask(SubTask subTask)
        {
            subTasks.Remove(subTask);
        }
    }
}
