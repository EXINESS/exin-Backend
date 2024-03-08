using backend.Domain.Cores;

namespace backend.Services
{
    public interface IUserService
    {
        string Login(User user);
    }
}
