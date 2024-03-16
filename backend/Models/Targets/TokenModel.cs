using backend.Domain.Cores;
namespace backend.Models.Targets
{
    public class TokenModel
    {
        public int UserId { get; set; }
        public TimeSpan Timeout { get; set; }
        public string? token { get; set; }

    }
}
