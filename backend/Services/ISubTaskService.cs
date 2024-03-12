using backend.Domain.Cores;
namespace backend.Services
{
    public interface ISubTaskService
    {
        IEnumerable<SubTask> GetAll();
        public  SubTask AddSubTask(SubTask subTask);
        public void DelSubTask( Guid id);
        //public int ChangeStatus()
    }
}
