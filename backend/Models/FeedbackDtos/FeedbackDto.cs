using backend.Domain.Cores;
namespace backend.Models.FeedbackDtos
{
    public class FeedbackDto
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Description { get; set; }
    }
}
