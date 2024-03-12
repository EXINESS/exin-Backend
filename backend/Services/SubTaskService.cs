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
        public string AddSubTask(SubTask subTask)
        {
            throw new NotImplementedException();
        }

        public SubTask DelSubTask(string subTaskName)
        {
            throw new NotImplementedException();
        }
    }
}
