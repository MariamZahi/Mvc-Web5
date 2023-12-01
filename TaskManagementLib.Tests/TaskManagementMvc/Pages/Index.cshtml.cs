using Microsoft.AspNetCore.Mvc.RazorPages;
using TaskManagementLib;

public class IndexModel : PageModel
{
    public List<TaskModel> Tasks { get; set; }

    public void OnGet()
    {
        // Retrieve tasks from a service or database
        // For simplicity, create some sample tasks
        Tasks = new List<TaskModel>
        {
            new TaskModel { Id = 1, Title = "Task 1", Description = "Description 1" },
            new TaskModel { Id = 2, Title = "Task 2", Description = "Description 2" },
        };
    }
}