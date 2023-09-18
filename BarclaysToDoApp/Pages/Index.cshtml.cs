using BarclaysToDoApp.Interfaces;
using BarclaysToDoApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BarclaysToDoApp.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ITaskService _taskService;

        public IndexModel(ITaskService service)
        {
            _taskService = service;
        }

        public List<TaskItems> ListOfTasks { get; set; }

        public void OnGet()
        {
            ListOfTasks = _taskService.GetTasks();           
        }
    }
}