namespace TecNM_Project_Template.backend.Modules.Health
{
    public class HealthStatusDto
    {
        public string Status { get; set; } = "Healthy";
        public DateTime Timestamp { get; set; } = DateTime.UtcNow;
        public string Service { get; set; } = "TecNM API";
    }
}
