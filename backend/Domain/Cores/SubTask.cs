using backend.Domain.Contracts;
namespace backend.Domain.Cores
{
    public class SubTask: Entity<int>
    {
        public int Id { get; set; }
        public string Name { get; set; }    
        public string Reason { get; set; }

    }
}
