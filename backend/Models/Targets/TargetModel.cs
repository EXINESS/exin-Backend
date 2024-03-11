using backend.Domain.Cores;
using backend.Models.Targets;
using System.ComponentModel.DataAnnotations;
namespace backend.Models.Targets
{
    public class TargetModel
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }

        public readonly List<SubTask> subTasks;

    }
}
