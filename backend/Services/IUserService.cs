using backend.Domain.Cores.UserAggregate;

namespace backend.Services
{
    public interface IUserService
    {
        string Login(User user);
    }
}
