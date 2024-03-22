using AutoMapper;
using backend.Domain.Cores.UserAggregate;
using backend.Models.UserDtos;
namespace backend.Mapping
{
    public class UserMapping:Profile
    {
        public UserMapping() {
            CreateMap<User,UserDto>();
        }
    }
}
