using System;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [ApiController]
    public class HealthCheckController : ControllerBase
    {
        [HttpGet("HealthCheck")]
        public IActionResult HealthCheck()
        {
            return Ok("OK");
        }
    }
}