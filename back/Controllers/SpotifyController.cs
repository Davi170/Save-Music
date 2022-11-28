using Microsoft.AspNetCore.Mvc;

namespace back.Controllers;

[ApiController]
[Route("Login")]
public class SpotifyController : ControllerBase
{
    
    
    [HttpGet]
    public async Task<IActionResult> Get()
    {
        
            return Ok();
    }

    [HttpGet("callback")]
    public async Task<IActionResult> Callback(string code, string state)
    {
        
        return Ok();
    }
}
