using Microsoft.AspNetCore.Mvc;

namespace back.Controllers;

[ApiController]
[Route("spotify")]
public class SpotifyController : ControllerBase
{
    [HttpGet]
    public async Task<IActionResult> Get()
    {
        HttpClient client = new HttpClient();
        client.BaseAddress = new Uri("https://accounts.spotify.com");
        var result = await client.GetAsync(
            "/authorize?response_type=code&client_id=${this.clientID}&" + 
            "scope=${this.scopes}-read-private user-read-email&redirect_uri=${this.redirectURI}&" +
            "state=CARACTERESALEATORIOS");
    }

    [HttpGet("callback")]
    public async Task<IActionResult> Callback()
    {
        
    }
}
