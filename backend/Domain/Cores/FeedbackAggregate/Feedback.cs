namespace backend.Domain.Cores.FeedbackAggregate
{
    public class Feedback : Entity<int>
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Description { get; set; }
    }
}
