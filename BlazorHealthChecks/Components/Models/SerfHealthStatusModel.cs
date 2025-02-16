namespace BlazorHealthChecks.Models;

public class HealthCheckModel
{
    public string Name { get; set; }
    public bool IsHealthy { get; set; }
    public DateTime OnStateFrom { get; set; }
    public DateTime LastExecution { get; set; }
}
