public class SpotifyService
{
    public async Task<string> SendToken(SpotifyToken token)
    {
        HttpClient client = new HttpClient();
        client.BaseAddress = new Uri("https://localhost:7008");
        var content = await client.PostAsJsonAsync("spotify", token);

        return await content.Content.ReadAsStringAsync();
    }
}