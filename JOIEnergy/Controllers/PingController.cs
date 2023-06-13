namespace JOIEnergy.Controllers;
using Microsoft.AspNetCore.Mvc;

public class PingController: Controller
{
    [HttpPost("ping")]
    public ObjectResult Ping([FromBody] string message)
    {
        return new ObjectResult($"Message received by server:{message}");
    }
}
