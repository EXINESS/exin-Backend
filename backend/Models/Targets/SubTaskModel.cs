using System.ComponentModel.DataAnnotations;

namespace backend.Models.Targets
{
    public class SubTaskModel
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Reason { get; set; }
    }
}
