using backend.Domain.Cores.AchiveAggregate;
namespace backend.Services
{
    public interface IAchiveSerive
    {
        Achive GetById(Guid id);
        public void DelAchive (Guid id);
        IEnumerable<Achive> GetAll();
        public void  AddAchive(Achive achive);
        public void EditeAchive (Achive achive);
    }
}
