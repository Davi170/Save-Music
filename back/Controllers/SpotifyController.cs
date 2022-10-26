using Microsoft.AspNetCore.Mvc;

namespace back.Controllers;

[ApiController]
[Route("spotify")]
public class SpotifyController : ControllerBase
{
    [HttpGet]
    public async Task<IActionResult> Get()
    {
        var client_id = "c3f60b3448904bb388f72beee6fccff9";
        var redirect_uri = "https://localhost:7231/";
        
        HttpClient client = new HttpClient();
        client.BaseAddress = new Uri("https://accounts.spotify.com");
        var result = await client.GetAsync(
            "/authorize?response_type=code&client_id=c3f60b3448904bb388f72beee6fccff9&" + 
            "scope=playlist-read-private playlist-read-collaborative playlist-modify-private playlist-modify-public-read-private user-read-email&redirect_uri=https://localhost:7231/&" +
            "state=CARACTERESALEATORIOS");
    }

    [HttpGet("callback")]
    public async Task<IActionResult> Callback()
    {
        
    }
}
