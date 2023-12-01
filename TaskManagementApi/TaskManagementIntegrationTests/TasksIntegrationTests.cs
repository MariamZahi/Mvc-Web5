using System.Net.Http;
using System.Threading.Tasks;
using Xunit;

public class TasksIntegrationTests : IClassFixture<WebApplicationFactory<TaskManagementApi.Startup>>
{
    private readonly HttpClient _client;

    public TasksIntegrationTests(WebApplicationFactory<TaskManagementApi.Startup> factory)
    {
        _client = factory.CreateClient();
    }

    [Fact]
    public async Task GetTasks_ReturnsSuccessStatusCode()
    {
        var response = await _client.GetAsync("/api/tasks");
        response.EnsureSuccessStatusCode();
    }
}
