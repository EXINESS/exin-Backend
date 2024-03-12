using backend.Domain.Cores;
using System.Collections.Generic;
using System.Text;
using backend.Services;

namespace backend.Services
{
    public class TargetService : ITargetService
    {
        private readonly List<Target> _targets;
        //private readonly List<SubTask> _subtasks;

        public TargetService()
        {
                _targets = new List<Target>();
        }
        public IEnumerable<Target> GetAll()
        {
            return _targets;
        }
        public string AddSubTask(SubTask subTask)
        {
            throw new NotImplementedException();
        }

        public string AddTarget(Target target)
        {
            throw new NotImplementedException();
        }

        public string DelTarget(Target target)
        {
            throw new NotImplementedException();
        }
    }
}
