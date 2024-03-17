using backend.Domain.Cores.TargetAggregate;
namespace backend.Services
{
    public interface ITargetService
    {
        public Target AddTarget(Target target);
        public void DelTarget(Guid id);
        public SubTask  AddSubTask(SubTask subTask);
        IEnumerable<Target> GetAll();
       Target GetById(Guid id);

    }
}
