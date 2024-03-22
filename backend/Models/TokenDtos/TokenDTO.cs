using backend.Domain.Cores;
namespace backend.Models.TokenDtos
{
    public class TokenDto
    {
        public int UserId { get; set; }
        public TimeSpan Timeout { get; set; }
        public string? token { get; set; }

    }
}
