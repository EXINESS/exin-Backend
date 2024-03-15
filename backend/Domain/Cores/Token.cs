using backend.Domain.Contracts;
using System.Threading;

namespace backend.Domain.Cores
{
    public class Token: Entity<int>
    {
        public int Id {  get; set; }
        public int UserId { get; set; }
        public TimeSpan Timeout { get; set; }

    }
}
