using Microsoft.AspNetCore.Mvc;

namespace back.Controllers;

[ApiController]
[Route("Login")]
public class SpotifyController : ControllerBase
{
    [HttpGet]
    public async Task<IActionResult> Get()
    {
        var client_id = "c3f60b3448904bb388f72beee6fccff9";
        var redirect_uri = "https://localhost:7231/playlists";
        
        HttpClient client = new HttpClient();
        client.BaseAddress = new Uri("https://accounts.spotify.com");
        var state = "daviDAVId4v1ivad"
        var callback = "https://localhost:7231/callback"
        var result = await client.GetAsync(
            "https://accounts.spotify.com/authorize?response_type=code&client_id=c3f60b3448904bb388f72beee6fccff9&" + 
            "scope=playlist-read-collaborative playlist-modify-public playlist-read-private playlist-modify-private&redirect_uri=" + callback + "&" +
            "state=" + state);
            return Ok();
    }

    [HttpGet("callback")]
    public async Task<IActionResult> Callback(string code, string state)
    {
        return Ok();
    }
}
