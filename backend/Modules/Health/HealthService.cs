namespace TecNM_Project_Template.backend.Modules.Health
{
    public interface IHealthService
    {
        HealthStatusDto GetHealthStatus();
    }

    public class HealthService : IHealthService
    {
        public HealthStatusDto GetHealthStatus()
        {
            return new HealthStatusDto();
        }
    }
}
