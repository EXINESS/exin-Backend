using AutoMapper;
using backend.Domain.Cores.SubTaskAggregate;
using backend.Models.SubTaskDtos;
namespace backend.Mapping
{
    public class SubTaskMapping:Profile
    {
        public SubTaskMapping() {
            CreateMap<SubTask,SubTaskDto>();
        }
    }
}
