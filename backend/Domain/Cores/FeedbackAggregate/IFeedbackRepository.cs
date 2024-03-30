using backend.Domain.Cores.TokenAggregate;

namespace backend.Domain.Cores.FeedbackAggregate
{
    public interface IFeedbackRepository
    {
        Task<Feedback?> GetFeedbackByIdAsync(Guid guid, Token token);
    }
}
