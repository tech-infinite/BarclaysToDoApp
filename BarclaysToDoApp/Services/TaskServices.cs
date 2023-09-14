using BarclaysToDoApp.Models;

namespace BarclaysToDoApp.Services
{
    public class TaskServices
    {
        // Adding in-memory collection to store the tasks
        private List<TaskItems> tasks;

        
        public TaskServices() 
        {
            // To initialize the tasks list here
            tasks = new List<TaskItems>();
        }

        public void AddTask(TaskItems task) 
        {
            tasks.Add(task);
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

        public void DeleteTask(int taskID) 
        {
            TaskItems taskToRemove = tasks.FirstOrDefault(t => t.TaskId == taskID);
            if (taskToRemove != null) 
            {
                tasks.Remove(taskToRemove);
            }
        }
    }
}
