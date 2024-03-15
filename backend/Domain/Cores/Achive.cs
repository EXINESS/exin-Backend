using backend.Domain.Contracts;
namespace backend.Domain.Cores
{
    public class Achive: Entity<int>
    {
        public int Id { get; set; }
        public int UserId { get; set; }

        public readonly List<Target> targets;

    }
}
