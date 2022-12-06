using Microsoft.AspNetCore.Mvc;

namespace back.Controllers;

using Model;

[ApiController]
[Route("spotify")]
public class SpotifyController : ControllerBase
{
    [HttpPost]
    public async Task Post([FromBody]spotifyToken token)
    {
        UsuarioToken userToken = new UsuarioToken();
        userToken.AccessToken = token.Access_Token;

        using TccContext context = new TccContext();
        context.Add(userToken);
        context.SaveChanges();
    }

    [HttpGet]
    public async Task<IActionResult> Get()
    {
        return NotFound();
    }
}
