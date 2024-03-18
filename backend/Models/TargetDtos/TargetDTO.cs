using backend.Domain.Cores.SubTaskAggregate;
using backend.Models.Targets;
using System.ComponentModel.DataAnnotations;
namespace backend.Models.Targets
{
    public class TargetDTO
    {
        public Guid Id { get; set; }
        [Required]
        public string Name { get; set; }

        public readonly List<SubTask> subTasks;

    }
}
