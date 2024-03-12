using backend.Domain.Cores;
namespace backend.Services
{
    public interface ISubTaskService
    {
        IEnumerable<SubTask> GetAll();
        public string AddSubTask(SubTask subTask);
        public SubTask DelSubTask(string subTaskName);
        //public int ChangeStatus()
    }
}
