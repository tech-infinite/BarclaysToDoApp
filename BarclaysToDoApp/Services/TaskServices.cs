using BarclaysToDoApp.Interfaces;
using BarclaysToDoApp.Models;

namespace BarclaysToDoApp.Services
{
    public class TaskServices : ITaskService
    {
        // Adding in-memory collection to store the tasks
        private List<TaskItems> tasks;       
        public TaskServices() 
        {
            // To initialize the tasks list here
            tasks = new List<TaskItems>();
        }

        public bool AddTask(TaskItems task) 
        {
            if (hasDuplicateName(task.TaskName))
            {
                return false;
            }
            
            tasks.Add(task);
            return true;
        }

        // Method to Edit a task by it's ID
        public void EditTask(int taskID, TaskItems updatedTask) 
        {
            TaskItems currentTask = tasks.FirstOrDefault(t => t.TaskId == taskID);
            if (currentTask != null) 
            {
                currentTask.TaskName = updatedTask.TaskName;
                currentTask.Priority = updatedTask.Priority;
                currentTask.Status = updatedTask.Status;
            }
        }

        public List<TaskItems> GetTasks() 
        {
            return tasks;
        }

        public TaskItems GetTaskById(int taskID) 
        {
            return tasks.FirstOrDefault(task => task.TaskId == taskID);
        }

        public void DeleteTask(int taskID) 
        {
            TaskItems taskToRemove = tasks.FirstOrDefault(t => t.TaskId == taskID);
            if (taskToRemove != null) 
            {
                tasks.Remove(taskToRemove);
            }
        }

        private bool hasDuplicateName(string taskName) 
        {
            return tasks.Any(task => string.Equals(task.TaskName, taskName, StringComparison.OrdinalIgnoreCase));
        }

    }
}
