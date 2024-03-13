using backend.Domain.Cores;
using backend.Services;
namespace backend.Services
{
    public class SubTaskService : ISubTaskService
    {
        private readonly List<SubTask> _subtasks;
        public SubTaskService()
        {
                _subtasks = new List<SubTask>();
        }

        public IEnumerable<SubTask> GetAll()
        {
            return _subtasks;
        }
        public SubTask AddSubTask(SubTask subtask)
        {
            subtask.Id = Guid.NewGuid();
            _subtasks.Add(subtask);
            return subtask;
        }

        public void DelSubTask(Guid id)
        {
           var test=_subtasks.First(t => t.Id == id);
            _subtasks.Remove(test);
        }

        public int ChangeStatus(ISubTaskService.State state)
        {
            throw new NotImplementedException();
        }
    }
}
