using BarclaysToDoApp.Interfaces;
using BarclaysToDoApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BarclaysToDoApp.Pages
{
    public class EditTaskModel : PageModel
    {
        private readonly ITaskService _taskService;

        public TaskItems Task { get; set; }

        public EditTaskModel(ITaskService taskService)
        {
            _taskService = taskService;
        }
        public IActionResult OnGet(int taskID)
        {
            Task = _taskService.GetTaskById(taskID);

            if (Task == null) 
            {
                return NotFound();
            }
            return Page();
        }
        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _taskService.EditTask(Task.TaskId, Task);

            return RedirectToPage("/Index");
        }
    }
}
