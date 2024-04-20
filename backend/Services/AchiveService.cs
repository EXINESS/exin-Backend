using backend.Domain.Cores.AchiveAggregate;
using backend.Services;
using Microsoft.AspNetCore.Http.HttpResults;

namespace backend.Services
{
    public class AchiveService : IAchiveSerive
    {

        private readonly List<Achive> _achives;

        public AchiveService()
        {
                _achives = new List<Achive>();
        }
         public IEnumerable<Achive>GetAll()
        {
            return _achives;
        }
        public  Achive AddAchive(Achive achive)
        {
            //achive.Id = new Achive
            _achives.Add(achive);
            return achive;
        }

        public void DelAchive(Guid id)
        {
            throw new NotImplementedException();
        }

        public void EditeAchive(Achive achive)
        {
            throw new NotImplementedException();
        }
        //public Achive GetById(Guid id) => _achives.Where(a => a.Id == id).FirstOrDefault();
    }
}
