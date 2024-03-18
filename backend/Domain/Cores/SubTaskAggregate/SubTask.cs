using backend.Domain.Contracts;
namespace backend.Domain.Cores.SubTaskAggregate
{
    public class SubTask : Entity<int>
    {
        public enum State
        {
            NotDone = 1,
            SuccessbygivingReason = 2,
            SuccesswithoutReason = 3,
            FailuretoStatetheReason = 4,
            FailurWithoutReason = 5
        }
        public Guid Id { get; set; }
        public string Name { get; set; }
        public State Status { get; set; }
        public string Reason { get; set; }



    }
}
