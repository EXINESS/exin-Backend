
namespace backend.Domain.Cores.TokenAggregate
{
    public interface ITokenRepository
    {
        //Task<Token> GetTokenAsync(Token token);
        Task<Token> CheckTokenAsync(Token token);
    }
}
