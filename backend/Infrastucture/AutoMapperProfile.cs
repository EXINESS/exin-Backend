using AutoMapper;
using backend.Domain.Cores;
using backend.Models.Users;
namespace backend.Infrastucture
{
    public class AutoMapperProfile:Profile
    {
        public AutoMapperProfile() {
            CreateMap<User, UserModel>();
        }
    }
}
