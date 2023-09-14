using System.ComponentModel.DataAnnotations;

namespace BarclaysToDoApp.Models
{
    public class TaskItems
    {
        
        public int TaskId { get; set; }

        [Required(ErrorMessage = "Task Name field is required.")]
        public string TaskName { get; set; }

        [Required(ErrorMessage ="Priority field is required.")]
        [Range(1, 5, ErrorMessage = "Please select the Priority between 1 and 5")]
        public int Priority { get; set; }

        [Required(ErrorMessage = "Status field is required.")]
        public string Status { get; set; }
    }
}
