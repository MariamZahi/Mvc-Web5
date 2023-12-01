using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using TaskManagementLib;

[ApiController]
[Route("api/tasks")]
public class TasksController : ControllerBase
{
    private readonly List<TaskModel> _tasks = new List<TaskModel>
    {
        new TaskModel { Id = 1, Title = "Task 1", Description = "Description 1" },
        new TaskModel { Id = 2, Title = "Task 2", Description = "Description 2" },
    };

    [HttpGet]
    public ActionResult<IEnumerable<TaskModel>> GetTasks()
    {
        return Ok(_tasks);
    }
}