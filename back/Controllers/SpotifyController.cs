using Microsoft.AspNetCore.Mvc;

namespace back.Controllers;

using System.Net;
using Model;
using Trevisharp.Security.Jwt;

[ApiController]
[Route("spotify")]
public class SpotifyController : ControllerBase
{
    [HttpPost]
    public async Task<IActionResult> Post(
        [FromBody]spotifyToken token,
        [FromServices]CryptoService jwt)
    {
        UsuarioToken userToken = new UsuarioToken();
        userToken.AccessToken = token.Access_Token;

        using TccContext context = new TccContext();
        context.Add(userToken);
        context.SaveChanges();

        return Ok(jwt.GetToken(userToken.UsuarioId));
    }

    [HttpGet]
    public async Task<IActionResult> Get(string token,
        [FromServices]CryptoService jwt)
    {
        int? id = null;
        try
        {
            id = jwt.Validate<int?>(token);
        }
        catch
        {
           
        }
            HttpClient cliente = new HttpClient();
            var url = "https://api.spotify.com/v1/me/playlists";
            var header = "Content-Type: application/json";
            var Authorization = $"Bearer {token}";
        
        return NotFound();
    }
} 
