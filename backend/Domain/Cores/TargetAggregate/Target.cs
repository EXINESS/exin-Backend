using backend.Domain.Contracts;
using backend.Domain.Cores.SubTaskAggregate;
namespace backend.Domain.Cores.TargetAggregate
{
    public class Target : Entity<int>
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public readonly List<SubTask> _subTask;
        public virtual IReadOnlyCollection<SubTask> SubTasks=> _subTask;
        public Target()
        {
            _subTask = new List<SubTask>();
        }
        public void AddSubTask(SubTask subTask)
        {
            _subTask.Add(subTask);
        }

        public void RemoveSubTask(SubTask subTask)
        {
            _subTask.Remove(subTask);
        }
    }
}
