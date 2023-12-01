using Xunit;
using TaskManagementLib;

public class TaskModelTests
{
    [Fact]
    public void TaskModel_Validation()
    {
        var task = new TaskModel();
        var validationContext = new System.ComponentModel.DataAnnotations.ValidationContext(task);
        var results = new System.Collections.Generic.List<System.ComponentModel.DataAnnotations.ValidationResult>();

        var isValid = Validator.TryValidateObject(task, validationContext, results, true);

        Assert.False(isValid, "TaskModel should not be valid without required fields");
        Assert.Single(results, r => r.MemberNames.Contains("Title"));
    }
}