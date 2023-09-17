using BarclaysToDoApp.Interfaces;
using BarclaysToDoApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BarclaysToDoApp.Pages
{
    public class CreateModel : PageModel
    {
        private readonly ITaskService _taskService;

        [BindProperty]
        public TaskItems Task { get; set; }

        public CreateModel(ITaskService taskService)
        {
            _taskService = taskService;
        }
        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            // Adds new task to task services
            _taskService.AddTask(Task);

            //redirects to the task list 
            return RedirectToPage("/Index");
        }
    }
}
