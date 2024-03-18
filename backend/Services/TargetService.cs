using System.Collections.Generic;
using System.Text;
using backend.Services;
using backend.Domain.Cores.TargetAggregate;
using backend.Domain.Cores.SubTaskAggregate;

namespace backend.Services
{
    public class TargetService : ITargetService
    {
        private readonly List<Target> _targets;
        private readonly List<SubTask> _subtasks;

        public TargetService()
        {
                _targets = new List<Target>();
        }
        public IEnumerable<Target> GetAll()
        {
            return _targets;
        }
        public SubTask AddSubTask(SubTask subTask)
        {
            subTask.Id = Guid.NewGuid();
            _subtasks.Add(subTask);
            return subTask;
        }

        public Target AddTarget(Target target)
        {
            target.Id = Guid.NewGuid();
            _targets.Add(target);
            return target;
        }

        public void DelTarget(Guid id)
        {
           var test=_targets.First(t => t.Id == id);
            _targets.Remove(test);
        }

        public Target GetById(Guid id) => _targets.Where(a => a.Id == id).FirstOrDefault();
    }
}
