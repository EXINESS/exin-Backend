using System.ComponentModel.DataAnnotations;

namespace backend.Models.SubTaskDtos
{
    public class SubTaskDTO
    {
        public enum State
        {
            NotDone = 1,
            SuccessbygivingReason = 2,
            SuccesswithoutReason = 3,
            FailuretoStatetheReason = 4,
            FailurWithoutReason = 5
        }
        public Guid Id { get; set; }
        [Required]
        public string Name { get; set; }
        public State Reason { get; set; }
    }
}
