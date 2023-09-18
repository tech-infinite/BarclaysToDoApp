using BarclaysToDoApp.Models;
using BarclaysToDoApp.Services;
using NUnit.Framework;
using System.Collections.Generic;
using Xunit;

public class TaskServiceTests
{
    [Fact]
    public void AddTask_Should_Add_Task()
    {
        // Arrange
        var service = new TaskServices();
        var task = new TaskItems { TaskName = "Test Task", Priority = 1, Status = "Not Started" };

        // Act
        service.AddTask(task);

        // Assert
        var tasks = service.GetTasks();
        Assert.NotNull(tasks);
        Assert.Equals(task, tasks[0]);
    }

    [Fact]
    public void EditTask_Should_Edit_Task()
    {
        // Arrange
        var service = new TaskServices();
        var task = new TaskItems { TaskId = 1, TaskName = "Test Task", Priority = 1, Status = "Not Started" };
        service.AddTask(task);

        var updatedTask = new TaskItems { TaskId = 1, TaskName = "Updated Task", Priority = 2, Status = "In Progress" };

        // Act
        service.EditTask(1, updatedTask);

        // Assert
        var editedTask = service.GetTaskById(1);
        Assert.NotNull(editedTask);
        Assert.Equals("Updated Task", editedTask.TaskName);
        Assert.Equals(2, editedTask.Priority);
        Assert.Equals("In Progress", editedTask.Status);
    }

    [Fact]
    public void DeleteTask_Should_Delete_Task()
    {
        // Arrange
        var service = new TaskServices();
        var task = new TaskItems { TaskId = 1, TaskName = "Test Task", Priority = 1, Status = "Not Started" };
        service.AddTask(task);

        // Act
        service.DeleteTask(1);

        // Assert
        var tasks = service.GetTasks();
        Assert.IsEmpty(tasks);
    }
}
