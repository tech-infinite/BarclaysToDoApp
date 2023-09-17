using BarclaysToDoApp.Models;

namespace BarclaysToDoApp.Interfaces
{
    public interface ITaskService
    {
        List<TaskItems> GetTasks();
        TaskItems GetTaskById(int taskId);
        bool AddTask(TaskItems task);
        void EditTask(int id, TaskItems task);
        void DeleteTask(int id);
    }
}
