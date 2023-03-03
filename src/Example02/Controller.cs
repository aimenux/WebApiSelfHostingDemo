using Microsoft.AspNetCore.Mvc;

namespace Example02;

[ApiController]
[Route("api")]
public class Controller : ControllerBase
{
    [HttpGet]
    public string GetRunningMessage()
    {
        return "Self hosted api is running";
    }
}