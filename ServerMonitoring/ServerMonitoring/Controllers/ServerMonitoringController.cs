using Microsoft.AspNetCore.Mvc;

namespace ServerMonitoring.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ServerMonitoringController : ControllerBase
    {

        [HttpGet(Name = "GetServerName")]
        public string Get()
        {
            return Environment.MachineName;
        }
    }
}