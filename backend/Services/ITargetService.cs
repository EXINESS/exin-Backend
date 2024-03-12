using backend.Domain.Cores;
namespace backend.Services
{
    public interface ITargetService
    {
        public string AddTarget(Target target);
        public string DelTarget(Target target);
        public string  AddSubTask(SubTask subTask);
        IEnumerable<Target> GetAll();
     
    }
}
