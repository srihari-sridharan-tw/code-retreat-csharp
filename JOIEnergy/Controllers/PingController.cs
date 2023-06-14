namespace JOIEnergy.Controllers;

using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

public class PingController: Controller
{
    [EnableCors("_myAllowSpecificOrigins")]
    [HttpPost("ping")]
    public ObjectResult Ping([FromBody] string message)
    {
        return new ObjectResult($"Message received by server:{message}");
    }
}
