using AutoMapper;
using backend.Domain.Cores.TargetAggregate;
using backend.Models.TargetDtos;
using backend.Models.Targets;

namespace backend.Mapping
{
    public class TargetMapping:Profile
    {
        public TargetMapping() {
            CreateMap<Target,TargetDto>();
            CreateMap<TargetForAddDto, Target>();
            CreateMap<TargetForEditeDto, Target>();
        }
    }
}
