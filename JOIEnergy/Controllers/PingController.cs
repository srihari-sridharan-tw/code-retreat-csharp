namespace JOIEnergy.Controllers;

using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

public class PingController: Controller
{
    [EnableCors("MyPolicy")]
    [HttpPost("ping")]
    public ObjectResult Ping([FromBody] string message)
    {
        return new ObjectResult($"Message received by server:{message}");
    }
}
