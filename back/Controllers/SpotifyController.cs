using Microsoft.AspNetCore.Mvc;

namespace back.Controllers;

[ApiController]
[Route("spotify")]
public class SpotifyController : ControllerBase
{
    [HttpPost]
    public async Task Post([FromBody]spotifyToken token)
    {
           
    }
}
