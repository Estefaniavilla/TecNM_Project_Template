using Microsoft.AspNetCore.Mvc;

namespace TecNM_Project_Template.backend.Modules.Health
{
    [ApiController]
    [Route("api/[controller]")]
    public class HealthController : ControllerBase
    {
        private readonly IHealthService _healthService;

        public HealthController(IHealthService healthService)
        {
            _healthService = healthService;
        }

        [HttpGet]
        public IActionResult GetHealth()
        {
            var status = _healthService.GetHealthStatus();
            return Ok(status);
        }
    }
}
