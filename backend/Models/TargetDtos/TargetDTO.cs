using backend.Domain.Cores.SubTaskAggregate;
using backend.Models.Targets;
using System.ComponentModel.DataAnnotations;
using backend.Models.SubTaskDtos;
namespace backend.Models.Targets
{
    public class TargetDto
    {
        public Guid Id { get; set; }
        [Required]
        public string Name { get; set; }

      public List<SubTaskDto> subTasks { get; set; }

    }
}
