using backend.Domain.Contracts;
using Microsoft.Identity.Client;
namespace backend.Domain.Cores.AchiveAggregate
{
    public class Achive : Entity<int>
    {
        public int Id { get; set; }
        public int UserId { get; set; }

        public string? Description { get; set; }



    }
}
