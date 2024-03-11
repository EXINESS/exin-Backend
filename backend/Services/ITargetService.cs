using backend.Domain.Cores;
namespace backend.Services
{
    public interface ITargetService
    {
        public string ReadTarget(Target target);
        public string WriteTarget(Target target);
        public string  AddSubTask(SubTask subTask);
    }
}
