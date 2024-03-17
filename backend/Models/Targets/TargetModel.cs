using backend.Domain.Cores.TargetAggregate;
using backend.Models.Targets;
using System.ComponentModel.DataAnnotations;
namespace backend.Models.Targets
{
    public class TargetModel
    {
        public Guid Id { get; set; }
        [Required]
        public string Name { get; set; }

        public readonly List<SubTask> subTasks;

    }
}
